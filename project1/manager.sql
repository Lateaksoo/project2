DROP TABLE IF EXISTS Manager;
CREATE TABLE Manager(
	uid INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(80) unique NOT NULL,
	pw VARCHAR(max) Not null,
	phonenum VARCHAR(20) NOT NULL,
	email VARCHAR(max),
	regdate DATETIME DEFAULT CURRENT_TIMESTAMP
);
insert INTO Manager (name,pw, phonenum,email)
values ('ssknu','rlarjsdn94', '010-2242-9544', 'ssknu@naver.com')
	  ,('teaksoo', 'asdf1234', '010-0000-0000',''); 
select * from Manager;