DROP TABLE IF EXISTS products;

CREATE TABLE products (
    category VARCHAR(50) NOT NULL,
    keyword_name VARCHAR(50) NOT NULL,
);

INSERT INTO products (category, keyword_name) VALUES ('50000089', '데스크탑');
INSERT INTO products (category, keyword_name) VALUES ('50000151', '노트북');
INSERT INTO products (category, keyword_name) VALUES ('50000153', '모니터');
INSERT INTO products (category, keyword_name) VALUES ('50002927', '키보드/마우스');

SELECT * FROM products;