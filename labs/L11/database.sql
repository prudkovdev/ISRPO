CREATE DATABASE alarm_clock;
GO

USE alarm_clock;
GO

CREATE TABLE alarms (
    id INT PRIMARY KEY IDENTITY(1,1),
    alarm_time TIME(7) NOT NULL,
    is_active BIT NOT NULL,
    repeat_daily BIT NOT NULL,
    label NVARCHAR(128),
    created_date DATETIME NOT NULL
);
