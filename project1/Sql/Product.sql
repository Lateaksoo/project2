 DROP TABLE IF EXISTS Product;
 CREATE TABLE Product(
	uid INT PRIMARY KEY IDENTITY(1,1), --상품코드
	name VARCHAR(80) unique NOT NULL,  -- 상품명
	price int NOT NULL,				   -- 가격 
	phonenum VARCHAR(20) NOT NULL,
	email VARCHAR(max),
	regdate DATETIME DEFAULT CURRENT_TIMESTAMP
);

insert INTO Product (name,pw, phonenum,email)
values ('ssknu','rlarjsdn94', '010-2242-9544', 'ssknu@naver.com')
	  ,('teaksoo', 'asdf1234', '010-0000-0000',''); 
select * from Product;


--아직 create ㄴㄴㄴㄴㄴㄴ