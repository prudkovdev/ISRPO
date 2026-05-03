using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainForm : Form
    {
        // Параметры игрового поля
        private const int GridWidth = 20;      // ширина в клетках
        private const int GridHeight = 20;     // высота в клетках
        private const int CellSize = 25;       // размер клетки в пикселях
        private const int TimerInterval = 150; // интервал таймера (мс)

        // Состояние игры
        private Timer gameTimer;
        private List<Point> snake = new List<Point>();
        private Point food;
        private Direction currentDirection;
        private int score = 0;
        private bool isGameOver = false;
        private DateTime gameStartTime;

        private Panel gamePanel;
        private Label scoreLabel;
        private Label statusLabel;

        private readonly string connectionString = "Server=IDEAPADS145\\SQLEXPRESS;Database=snake_game;Trusted_Connection=True;";

        public MainForm()
        {
            InitializeComponent();
            SetupGame();
        }

        private void InitializeComponent()
        {
            this.gamePanel = new Panel();
            this.scoreLabel = new Label();
            this.statusLabel = new Label();
            this.SuspendLayout();

            // gamePanel
            this.gamePanel.BackColor = Color.Black;
            this.gamePanel.Location = new Point(12, 12);
            this.gamePanel.Size = new Size(GridWidth * CellSize, GridHeight * CellSize);
            this.gamePanel.Paint += new PaintEventHandler(GamePanel_Paint);

            // scoreLabel
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            this.scoreLabel.Location = new Point(12, GridHeight * CellSize + 20);
            this.scoreLabel.Text = "Счет: 0";

            // statusLabel
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new Font("Arial", 12F);
            this.statusLabel.Location = new Point(200, GridHeight * CellSize + 20);
            this.statusLabel.Text = "";

            // MainForm
            this.ClientSize = new Size(GridWidth * CellSize + 30, GridHeight * CellSize + 80);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.statusLabel);
            this.Text = "Змейка";
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupGame()
        {
            // Начальная змейка (3 сегмента горизонтально)
            snake.Clear();
            snake.Add(new Point(10, 10));
            snake.Add(new Point(9, 10));
            snake.Add(new Point(8, 10));
            currentDirection = Direction.Right;
            score = 0;
            isGameOver = false;
            scoreLabel.Text = "Счет: 0";
            statusLabel.Text = "";
            gameStartTime = DateTime.Now;
            GenerateFood();
            StartTimer();
            gamePanel.Invalidate();
        }

        private void StartTimer()
        {
            if (gameTimer == null)
            {
                gameTimer = new Timer();
                gameTimer.Interval = TimerInterval;
                gameTimer.Tick += GameTimer_Tick;
            }
            gameTimer.Start();
        }

        private void StopTimer()
        {
            if (gameTimer != null)
                gameTimer.Stop();
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            do
            {
                food = new Point(rand.Next(0, GridWidth), rand.Next(0, GridHeight));
            } while (snake.Contains(food));
        }

        private void MoveSnake()
        {
            Point head = snake[0];
            Point newHead = head;

            switch (currentDirection)
            {
                case Direction.Up:
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score += 10;
                scoreLabel.Text = $"Счет: {score}";
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        private void CheckCollision()
        {
            Point head = snake[0];

            // Столкновение со стеной
            if (head.X < 0 || head.X >= GridWidth || head.Y < 0 || head.Y >= GridHeight)
            {
                GameOver();
                return;
            }

            // Столкновение с собственным телом
            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                    return;
                }
            }
        }

        private void GameOver()
        {
            if (isGameOver) return;
            isGameOver = true;
            StopTimer();

            TimeSpan gameDuration = DateTime.Now - gameStartTime;
            statusLabel.Text = "Игра окончена!";

            // Запрос имени игрока и сохранение
            string playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите ваше имя:", "Сохранение результата", "Игрок");
            if (!string.IsNullOrWhiteSpace(playerName))
            {
                SaveResultToDatabase(playerName, score, gameDuration);
                statusLabel.Text = "Результат сохранён!";
            }
            else
            {
                statusLabel.Text = "Результат не сохранён.";
            }

            // Предложение начать новую игру
            DialogResult result = MessageBox.Show("Хотите сыграть снова?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SetupGame();
            }
            else
            {
                statusLabel.Text = "Нажмите Пробел для новой игры";
            }
        }

        private void SaveResultToDatabase(string playerName, int score, TimeSpan duration)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO results (player_name, score, game_duration, game_date) VALUES (@name, @score, @duration, @date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(duration.TotalSeconds));
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Результат сохранён в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения в БД: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return;
            MoveSnake();
            CheckCollision();
            gamePanel.Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver && e.KeyCode == Keys.Space)
            {
                SetupGame();
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentDirection != Direction.Down)
                        currentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
            }
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Отрисовка сетки
            Pen gridPen = new Pen(Color.DarkGray, 1);
            for (int x = 0; x <= GridWidth; x++)
                g.DrawLine(gridPen, x * CellSize, 0, x * CellSize, GridHeight * CellSize);
            for (int y = 0; y <= GridHeight; y++)
                g.DrawLine(gridPen, 0, y * CellSize, GridWidth * CellSize, y * CellSize);

            // Отрисовка змейки
            foreach (Point p in snake)
            {
                g.FillRectangle(Brushes.Green, p.X * CellSize, p.Y * CellSize, CellSize - 1, CellSize - 1);
                g.DrawRectangle(Pens.DarkGreen, p.X * CellSize, p.Y * CellSize, CellSize - 1, CellSize - 1);
            }
            // Отрисовка головы другим цветом
            if (snake.Count > 0)
            {
                Point head = snake[0];
                g.FillRectangle(Brushes.LimeGreen, head.X * CellSize, head.Y * CellSize, CellSize - 1, CellSize - 1);
            }

            // Отрисовка еды
            g.FillEllipse(Brushes.Red, food.X * CellSize + 2, food.Y * CellSize + 2, CellSize - 5, CellSize - 5);
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}