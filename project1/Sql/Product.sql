 DROP TABLE IF EXISTS Product;
 CREATE TABLE Product(
	uid INT PRIMARY KEY IDENTITY(1,1), -- 상품코드
	name VARCHAR(80) unique NOT NULL,  -- 상품명
	price int NOT NULL,				   -- 가격 
	stock int NOT NULL,				   -- 재고
	image VARCHAR(80),				   -- 이미지 경로	
	category VARCHAR(max),			   -- 카테고리
);

insert INTO Product (name,price, stock,image,category)
values ('맥북','1000000', '2', '','노트북');
	
select * from Product;


