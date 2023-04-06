 DROP TABLE IF EXISTS Product;
 CREATE TABLE Product(
	uid INT PRIMARY KEY IDENTITY(1,1), -- 상품코드
	name VARCHAR(80) unique NOT NULL,  -- 상품명
	price int NOT NULL,				   -- 가격 
	stock int NOT NULL,				   -- 재고
	image VARCHAR(80),				   -- 이미지 경로	
	category VARCHAR(max) NOT NULL,	   -- 카테고리
	detail VARCHAR(max),			   -- 상세설명
);


	INSERT INTO Product (name, price, stock, image, category, detail)
VALUES ('맥북', 1000000, 2, 'D:\project2/Mac.png', '노트북', 'M1은 Mac용으로 Apple에서 직접 디자인한 최초의 칩입니다. Apple Silicon은 자그마한 칩 하나에 CPU, GPU, Neural Engine, I/O 등 수많은 요소가 통합되어 있죠. 160억 개라는 엄청난 수의 트랜지스터가 집적된 M1 칩은 발군의 성능과 맞춤형 기술, 믿을 수 없는 전력 효율성을 선사합니다. 가히 Mac 개발에 있어 획기적인 도약이라 할 수 있죠.');

select * from Product;
select * from Product where category = '노트북';


