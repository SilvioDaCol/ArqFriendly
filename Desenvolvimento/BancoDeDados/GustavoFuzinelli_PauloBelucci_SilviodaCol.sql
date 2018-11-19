drop schema public cascade;
create schema public;

create table professores(
	nome varchar (50),
	matricula varchar (7) primary key,
	curso varchar (100)
);

create table alunos(
	nome varchar (50),
	matricula varchar (7) primary key,
	curso varchar (100),
	semestre int
);

create table turma(
	id serial,
	sigla varchar (10),
    matricula_professor varchar (7),
    primary key (id,sigla),
    constraint chave_matricula_prof foreign key(matricula_professor)
        references professores(matricula) match simple on update no action on delete no action
);

create table participantesTurma(
	id_turma serial,
    sigla_turma varchar (10),
	criador varchar (7),
	aluno varchar(7), 
	primary key (id_turma,sigla_turma,criador,aluno),
    constraint chave_composta_turma foreign key(id_turma,sigla_turma)
        references turma(id,sigla) match simple on update no action on delete no action,
    constraint chaves_criador foreign key(criador)
        references professores(matricula) match simple on update no action on delete no action,
    constraint aluno_participante foreign key(aluno)
        references alunos(matricula) match simple on update no action on delete no action  
);

create table jogo(
	id_jogo serial primary key,
    nome_jogo varchar (50),
    jogador VARCHAR (7);
    jogador_aluno varchar (7),
    jogador_professor varchar (7),
    pontuacao int,
    constraint chave_jogador_aluno foreign key(jogador_aluno)
        references alunos(matricula) match simple on update no action on delete no action,
    constraint chave_jogador_professor foreign key(jogador_professor)
        references professores(matricula) match simple on update no action on delete no action
);

INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Tiago', '3001121', 'TADS_NOTURNO', 3);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Bruna', '3001122', 'TADS_NOTURNO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('João', '3001123', 'TADS_NOTURNO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Patricia', '3001124', 'TADS_NOTURNO',3);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Renato', '3001125', 'TADS_NOTURNO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Barbara', '3001126', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Gustavo', '3001127', 'TADS_VESPERTINO',3);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Larissa', '3001128', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Henrique', '3001129', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Juliana', '3001130', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Mario', '3001131', 'TADS_MATUTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Giovanna', '3001132', 'TADS_MATUTINO',1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Rodrigo', '3001133', 'TADS_MATUTINO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Mariana', '3001134', 'TADS_MATUTINO',1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Gabriel', '3001135', 'TADS_MATUTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Bruno', '66P3EU3', 'ELETRONICA_NOTURNO', 1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('ricardo', 'D2A8V66', 'ELETRONICA_VESPERTINO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('manuel', 'ZX9X8RA', 'TADS_NOTURNO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('francisco', 'CGTGN5G', 'TADS_NOTURNO',3);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('geraldo', 'WJE79AB', 'ELETRONICA_VESPERTINO', 1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('catarina', '7P9VQF3', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('urgot', '79DLZDH', 'ELETRONICA_VESPERTINO',3);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('leona', 'L2NYNGB', 'TADS_VESPERTINO',1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('irelia', '66XLWBN', 'TADS_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('camile', 'QE3ZEER', 'ELETRONICA_VESPERTINO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('singed', 'R8WEHDG', 'ELETRONICA_NOTURNO',2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('garen', 'RMD4N9B', 'ELETRONICA_NOTURNO',1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Marina', '3ELFVX9', 'ELETRONICA_NOTURNO', 2);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Celia', '56J2WQ5', 'TADS_MATUTINO',1);
INSERT INTO alunos(nome, matricula,curso, semestre) VALUES ('Cristina', '9LM5BUA', 'ELETRONICA_VESPERTINO',2);

INSERT INTO professores(nome, matricula,curso) VALUES ('Marcio', '8FF3WR9', 'ELETRONICA_VESPERTINO');
INSERT INTO professores(nome, matricula,curso) VALUES ('Jose', '3RNAR3Q', 'ELETRONICA_NOTURNO');
INSERT INTO professores(nome, matricula,curso) VALUES ('Diogo', 'QXTG8WM', 'ELETRONICA_NOTURNO');
INSERT INTO professores(nome, matricula,curso) VALUES ('Gerson', 'A4JLTKB', 'TADS_NOTURNO');
INSERT INTO professores(nome, matricula,curso) VALUES ('Luiz', 'T8W4GDK', 'TADS_MATUTINO');
INSERT INTO professores(nome, matricula,curso) VALUES ('Hamilton', 'HL6WG6U', 'ELETRONICA_VESPERTINO');

INSERT INTO turma(sigla,matricula_professor) VALUES ('ELETR_VER','8FF3WR9');
INSERT INTO turma(sigla,matricula_professor) VALUES ('ELETR_NOT', 'QXTG8WM');
INSERT INTO turma(sigla,matricula_professor) VALUES ('ELETR_NOT', 'A4JLTKB');
INSERT INTO turma(sigla,matricula_professor) VALUES ('TADS_M', 'T8W4GDK');

INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('1','ELETR_VER','8FF3WR9','D2A8V66');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('1','ELETR_VER','8FF3WR9','9LM5BUA');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('1','ELETR_VER','8FF3WR9','WJE79AB');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('1','ELETR_VER','8FF3WR9','79DLZDH');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('1','ELETR_VER','8FF3WR9','QE3ZEER');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('2','ELETR_NOT','QXTG8WM','66P3EU3');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('2','ELETR_NOT','QXTG8WM','R8WEHDG');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('2','ELETR_NOT','QXTG8WM','RMD4N9B');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('2','ELETR_NOT','QXTG8WM','3ELFVX9');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','3001131');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','3001132');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','3001133');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','3001134');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','3001135');
INSERT INTO participantesTurma(id_turma, sigla_turma, criador, aluno) VALUES ('4','TADS_M','T8W4GDK','56J2WQ5');

INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE',NULL,'56J2WQ5',2987);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('STARWARS',NULL,'R8WEHDG',3123);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE',NULL,'3001134',329080);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('STARWARS',NULL,'QE3ZEER',29872);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE',NULL,'56J2WQ5',28858);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE',NULL,'3ELFVX9',1094);

INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE','T8W4GDK',NULL,2987);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('STARWARS','T8W4GDK',NULL,3123);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE','QXTG8WM',NULL,329080);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('STARWARS','T8W4GDK',NULL,29872);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE','8FF3WR9',NULL,28858);
INSERT INTO jogo(id, nome_jogo, jogador_professor, jogador_aluno, pontuacao) VALUES ('ALGORACE','8FF3WR9',NULL,1094);  