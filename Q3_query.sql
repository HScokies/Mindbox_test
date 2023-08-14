-- Создание таблиц
CREATE TABLE Categories(
	c_id INT PRIMARY KEY IDENTITY(1,1),
	c_name VARCHAR(10)
);
CREATE TABLE Products(
	p_id INT PRIMARY KEY IDENTITY(1,1),
	p_name VARCHAR(10),
);
CREATE TABLE Products_Categories(
	id INT PRIMARY KEY IDENTITY(1,1),
	c_id INT FOREIGN KEY References Categories(c_id),
	p_id INT FOREIGN KEY References Products(p_id), 
);

-- Мок
INSERT INTO Categories(c_name) VALUES ('c1'), ('c2');
INSERT INTO Products(p_name) VALUES ('p1'), ('p2'), ('p3');
INSERT INTO Products_Categories(c_id, p_id) VALUES (1,1), (1,2), (2,1);

-- Запрос
SELECT 
    P.p_name, 
    C.c_name 
FROM 
    Products AS P
LEFT JOIN 
    Products_Categories AS PC ON P.p_id = PC.p_id
LEFT JOIN 
    Categories AS C ON C.c_id = PC.c_id
ORDER BY 
    P.p_name;
