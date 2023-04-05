DROP TABLE IF EXISTS category;

CREATE TABLE category (
    category VARCHAR(50) NOT NULL,
    keyword_name VARCHAR(50) NOT NULL,
);

INSERT INTO category (category, keyword_name) VALUES ('50000089', '데스크탑');
INSERT INTO category (category, keyword_name) VALUES ('50000151', '노트북');
INSERT INTO category (category, keyword_name) VALUES ('50000153', '모니터');
INSERT INTO category (category, keyword_name) VALUES ('50002927', '키보드/마우스');

SELECT * FROM category;