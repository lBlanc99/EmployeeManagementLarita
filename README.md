# EmployeeManagement


MySQL DB
CREATE DATABASE employee_management;

USE employee_management;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL -- Store hashed passwords in real apps, plain text here for simplicity
);

INSERT INTO users (username, password) VALUES ('admin', 'admin123');

CREATE TABLE employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    photo LONGBLOB,
    name VARCHAR(100) NOT NULL,
    address TEXT,
    phone VARCHAR(20),
    gender ENUM('Male', 'Female') NOT NULL
);
