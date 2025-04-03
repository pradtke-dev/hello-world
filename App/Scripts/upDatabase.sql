IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'todoDb')
  BEGIN
    CREATE DATABASE todoDb;
  END
GO

USE todoDb;
GO

