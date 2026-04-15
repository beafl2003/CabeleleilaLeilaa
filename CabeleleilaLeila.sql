
--- Criação do Banco de Dados
CREATE DATABASE CabeleleilaLeila;

USE CabeleleilaLeila;

-- Criação Tabelas 

Create table Agendamento(
	NumAgendamento int identity,
	ClienteId uniqueidentifier not null,
	Status char(1),
	CriadoEm DateTime,
	DtAgendamento DateTime,
	PrecoTotal Decimal
	Constraint PK_Agendamento primary key (NumAgendamento)

) 

insert into Agendamento
(ClienteId, Status, CriadoEm, DtAgendamento, PrecoTotal) values (
Create table AgendamentoServico(
	NumAgendamento int,
	CdServico varchar(100),
	Preco Decimal
	Constraint PK_AgendamentoServico primary key (NumAgendamento, CdServico)
) 

Create table Servico(
    Id uniqueidentifier,
    CdServico char(10),
    Descricao varchar(100),
	Preco Decimal
    primary key (Id)
)
alter table Servico add constraint UN_Servico_CdServico unique (CdServico);




Create table Usuario(
    Id uniqueidentifier,
    CdUsuario char(10),
    NomeUsuario varchar(100),
	Senha varchar(20),
    Ativo bit,
	TipoUsuario bit,
    primary key (Id)
)
alter table Usuario add constraint UN_Usuario_CdUsuario unique (CdUsuario);
						


                        
-- Criar o usuário Administrador para primeiro acesso

INSERT INTO Usuario
( Id, CdUsuario, NomeUsuario, Ativo, TipoUsuario, Senha )
VALUES
(NEWID(), 'ADM', 'administrador', 1,1, 'Adm123' )






            