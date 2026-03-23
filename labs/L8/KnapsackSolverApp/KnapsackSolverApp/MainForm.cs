using KnapsackSolverApp.Debugging;
using KnapsackSolverApp.Entities;
using KnapsackSolverApp.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KnapsackSolverApp
{
    public partial class MainForm : Form
    {
        private List<Item> _items;

        public MainForm()
        {
            InitializeComponent();
            _items = DatabaseHelper.GetItems();
        }

        private void InsertFromItemListToDGVItems(List<Item> items)
        {
            dgvItems.Rows.Clear();
            foreach (Item item in items)
                dgvItems.Rows.Add(
                    item.Id,
                    item.Name,
                    item.Weight,
                    item.Cost);

            DebugLogger.Log($"Отображено {dgvItems.Rows.Count} записей");
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var items = KnapsackSolver.Solve(_items, Convert.ToInt32(nudMaxWeight.Value));
            InsertFromItemListToDGVItems(items);
        }

        private void bShowSourceData_Click(object sender, System.EventArgs e)
        {
            _items = DatabaseHelper.GetItems();
            InsertFromItemListToDGVItems(_items);
        }

        private void bSolve_Click(object sender, System.EventArgs e)
        {
            DebugLogger.Log("Нажата кнопка: Решить");

            var items = KnapsackSolver.Solve(_items, Convert.ToInt32(nudMaxWeight.Value));
            InsertFromItemListToDGVItems(items);
        }
    }
}
