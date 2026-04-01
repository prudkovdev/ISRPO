CREATE DATABASE field_of_miracles;
GO

USE field_of_miracles;
GO

CREATE TABLE words (
    id INT PRIMARY KEY IDENTITY(1,1),
    word NVARCHAR(10) NOT NULL
);

INSERT INTO words (word) VALUES
('Помидор'),
('Трасса'),
('Крот'),
('Носок'),
('Кровать'),
('Ботинок'),
('Рама'),
('Снег'),
('Вишня'),
('Огонь'),
('Шляпа'),
('Шлак'),
('Серый'),
('Кислый'),
('Жало'),
('Кастет'),
('Водолаз'),
('Штора'),
('Перхоть'),
('Молоток');
GO
