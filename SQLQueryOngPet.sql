CREATE DATABASE ONGPet

USE ONGPet


CREATE TABLE Adotante(
	Nome varchar(50) NOT NULL,
	CPF varchar(11) NOT NULL,
	Sexo char(1)  NOT NULL,
	DataNascimento date Not NULL,
	Telefone varchar (11) NOT NULL,
	Logradouro varchar(50) NOT NULL,
	CEP varchar(8)NOT NULL,
	Complemento varchar(20),
	Numero int NOT NULL,
	Bairro varchar(30) NOT NULL,
	Cidade varchar(30) NOT NULL,
	Estado char(2) NOT NULL,
	CHIP int not null,
	DataAdocao date not null,

	FOREIGN KEY (CHIP) references Pet(CHIP),

	CONSTRAINT PK_CPF_Adotante PRIMARY KEY (CPF)
	);

CREATE TABLE Pet(
	CHIP int identity,
	Familia varchar(30)NOT NULL,
	Raca varchar(20)NOT NULL,
	Sexo char(1)NOT NULL,
	Nome varchar(50),
	Situacao char(1) NOT NULL
	CONSTRAINT PK_CHIP_Pet PRIMARY KEY (CHIP
);






--ver se está tudo ok nas tabelas

Select * from pet;
select * from adotante;