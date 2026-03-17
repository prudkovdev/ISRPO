CREATE DATABASE knapsack;
GO

USE knapsack;
GO

CREATE TABLE items (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(128) NOT NULL,
    weight INT NOT NULL,
    cost INT NOT NULL
);
GO

INSERT INTO items (name, weight, cost) VALUES
('Книга', 1, 600),
('Бинокль', 2, 5000),
('Аптечка', 4, 1500),
('Ноутбук', 2, 40000),
('Котелок', 1, 500);
GO
