CREATE DATABASE Armazem;

CREATE TABLE Produtos (
ProdutoId INT PRIMARY KEY,
Nome VARCHAR(50) NOT NULL,
Marca VARCHAR(50) NOT NULL,
Quantidade INT NOT NULL,
Preco FLOAT NOT NULL,
Peso FLOAT NOT NULL,
Setor VARCHAR(20) NOT NULL
);

SELECT * FROM Produtos;


INSERT INTO Produtos (ProdutoId, Nome, Marca, Quantidade, Preco, Peso, Setor) 
	Values(1, 'Tenis', 'Adidas', 10, 70.99, 1.2, 'Calçados'),
		  (2, 'Bone', 'QuikSilver', 20, 10.99, 0.2, 'Bonés'),
		  (3, 'Iphone', 'Apple', 20, 1000.99, 0.7, 'Tecnologia'),
		  (4, 'Notebook', 'LeNovo', 17, 799.99, 2.3, 'Tecnologia'),
		  (5, 'Monitor', 'Samsung', 9, 349.99, 1.2, 'Tecnologia'),
		  (6, 'Pneu', 'Michelan', 20, 889.99, 10.2, 'Automotivo'),
		  (7, 'Shampoo', 'Fructis', 50, 8.99, 0.1, 'Comésticos'),
		  (8, 'Sabonete', 'Pampers', 49, 0.99, 0.1, 'Cosméticos'),
		  (9, 'Panela', 'Tramontina', 20, 39.99, 0.5, 'Acessórios'),
		  (10, 'Creme Dental', 'Colgate', 50, 2.99, 0.1, 'Enxaguantes');


UPDATE Produtos SET Nome = 'SmartPhone', Marca = 'XYZ', Quantidade = 10, Preco = 700.00, Peso = 0.5, Setor = 'Tecnologia'
WHERE ProdutoId = 8;

DELETE FROM Produtos WHERE ProdutoId = 4;