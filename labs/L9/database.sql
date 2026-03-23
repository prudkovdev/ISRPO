IF DB_ID('characters_counting') IS NULL 
CREATE DATABASE characters_counting;

SELECT DB_ID('characters_counting')

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='file_operations' AND xtype='U')
BEGIN
    CREATE TABLE file_operations (
        id INT PRIMARY KEY IDENTITY(1,1),
        file_path NVARCHAR(500),
        content NVARCHAR(MAX),
        character_count INT,
        operation_type NVARCHAR(50),
        operation_date DATETIME DEFAULT GETDATE()
    )
END
