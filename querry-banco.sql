CREATE DATABASE banco;

USE banco;

CREATE TABLE  usuarios (
    nome VARCHAR(100),
    cpf VARCHAR(14),
    endereco VARCHAR(255),
    telefone VARCHAR(15),
    email VARCHAR(100),
    data_nascimento DATE,
    sexo CHAR(1)
);

DROP TABLE usuarios;