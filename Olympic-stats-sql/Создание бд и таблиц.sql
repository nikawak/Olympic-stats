use master;

CREATE DATABASE [Olympic-stats];
--DROP DATABASE [Olympic-stats];

use [Olympic-stats];

create table Functional_classes(
	id int identity(1,1),
	class nvarchar(8) not null,
	sex nchar(1) default 'ì' check(sex in('ì','æ')) not null,
	primary key(id)
);
--DROP TABLE FUNCTIONAL_CLASSES;

create table Disciplines(
	id int identity(1,1),
	name nvarchar (16) NOT NULL,
	primary key(id)
);

create table Conditions(
	id int identity(1,1),
	length int,
	timing_type nvarchar(16),
	primary key(id)
);

create table Sports_category(
	id int identity(1,1),
	name nvarchar(16) not null,
	time time,
	class_id int,
	discipline_id int,
	condition_id int,
);