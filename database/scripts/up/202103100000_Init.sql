create table test (
   id int generated always as identity primary key,
   name varchar(100) not null
);

create table users (
	id int generated always as identity primary key,
	testId int not null,
	usr varchar(50) not null,
	pwd varchar(50) null,
	constraint fk_users_test foreign key (testId) references test (id)
);
