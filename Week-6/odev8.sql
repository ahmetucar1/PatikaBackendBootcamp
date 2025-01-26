--test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
    id INTEGER PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);

--Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
INSERT INTO employee (id, name, birthday, email) VALUES
(1, 'John Doe', '1980-01-15', 'johndoe@example.com'),
(2, 'Jane Smith', '1990-05-22', 'janesmith@example.com'),
(3, 'Michael Johnson', '1985-07-30', 'michaelj@example.com'),
(4, 'Emily Davis', '1992-11-12', 'emilydavis@example.com'),
(5, 'David Brown', '1988-03-05', 'davidbrown@example.com'),
(6, 'Sarah Wilson', '1983-04-10', 'sarahwilson@example.com'),
(7, 'James Taylor', '1987-09-18', 'jamestaylor@example.com'),
(8, 'Patricia Lee', '1995-12-01', 'patricialee@example.com'),
(9, 'Robert Harris', '1992-03-20', 'robertharris@example.com'),
(10, 'Linda Clark', '1991-06-25', 'lindaclark@example.com'),
(11, 'William Lewis', '1986-07-12', 'williamlewis@example.com'),
(12, 'Elizabeth Walker', '1982-02-28', 'elizabethwalker@example.com'),
(13, 'Christopher Hall', '1989-08-09', 'christopherhall@example.com'),
(14, 'Jessica Allen', '1993-11-17', 'jessicaallen@example.com'),
(15, 'Daniel Young', '1984-05-14', 'danielyoung@example.com'),
(16, 'Matthew King', '1990-01-25', 'matthewking@example.com'),
(17, 'Barbara Scott', '1981-10-03', 'barbarascott@example.com'),
(18, 'Joseph Adams', '1987-02-15', 'josephadams@example.com'),
(19, 'Nancy Baker', '1994-04-22', 'nancybaker@example.com'),
(20, 'Thomas Gonzalez', '1988-06-10', 'thomasgonzalez@example.com'),
(21, 'Karen Perez', '1991-09-30', 'karenperez@example.com'),
(22, 'Charles Nelson', '1985-12-05', 'charlesnelson@example.com'),
(23, 'Susan Carter', '1989-01-18', 'susancarter@example.com'),
(24, 'Donald Mitchell', '1982-07-11', 'donmitchell@example.com'),
(25, 'Betty Roberts', '1990-03-08', 'bettyroberts@example.com'),
(26, 'Paul Evans', '1983-11-25', 'paulevans@example.com'),
(27, 'Sandra Collins', '1992-08-19', 'sandracollins@example.com'),
(28, 'George Stewart', '1984-04-17', 'georgestewart@example.com'),
(29, 'Mary Morris', '1995-01-09', 'marymorris@example.com'),
(30, 'Andrew Rogers', '1987-10-23', 'andrewrogers@example.com'),
(31, 'Dorothy Reed', '1994-02-02', 'dorothyreed@example.com'),
(32, 'Kenneth Cook', '1981-06-27', 'kennethcook@example.com'),
(33, 'Nancy Morgan', '1989-12-15', 'nancymorgan@example.com'),
(34, 'Frank Bell', '1986-05-03', 'frankbell@example.com'),
(35, 'Ruth Gonzalez', '1991-07-20', 'ruthgonzalez@example.com'),
(36, 'Steven Gray', '1985-03-11', 'stevengray@example.com'),
(37, 'Cynthia James', '1990-09-29', 'cynthiajames@example.com'),
(38, 'Brian White', '1983-01-21', 'brianwhite@example.com'),
(39, 'Helen King', '1994-04-13', 'helenking@example.com'),
(40, 'Jack Lee', '1987-12-17', 'jacklee@example.com'),
(41, 'Margaret Walker', '1982-08-22', 'margaretwalker@example.com'),
(42, 'Paul Hall', '1989-03-14', 'paulhall@example.com'),
(43, 'Samantha Allen', '1995-05-18', 'samanthaallen@example.com'),
(44, 'James Harris', '1992-10-04', 'jamesharris@example.com'),
(45, 'Patricia Young', '1981-04-30', 'patriciayoung@example.com'),
(46, 'Brian Mitchell', '1986-09-06', 'brianmitchell@example.com'),
(47, 'Jennifer Adams', '1993-06-18', 'jenniferadams@example.com'),
(48, 'Richard Clark', '1984-01-10', 'richardclark@example.com'),
(49, 'Mary Wilson', '1990-12-11', 'marywilson@example.com'),
(50, 'Steven Scott', '1988-02-03', 'stevenscott@example.com');


--Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
-- 1. Name güncelleme
UPDATE employee
SET name = 'Johnathan Doe'
WHERE id = 1;

-- 2. Birthday güncelleme
UPDATE employee
SET birthday = '1995-08-25'
WHERE id = 2;

-- 3. Email güncelleme
UPDATE employee
SET email = 'michael.johnson@newdomain.com'
WHERE id = 3;

-- 4. Name ve Birthday güncelleme
UPDATE employee
SET name = 'Emily Thompson', birthday = '1993-02-15'
WHERE id = 4;

-- 5. Email güncelleme
UPDATE employee
SET email = 'david.brown@workplace.com'
WHERE id = 5;


--Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
-- 1. id'si 1 olan satırı sil
DELETE FROM employee WHERE id = 1;

-- 2. name'i 'Jane Smith' olan satırı sil
DELETE FROM employee WHERE name = 'Jane Smith';

-- 3. email'i 'michaelj@example.com' olan satırı sil
DELETE FROM employee WHERE email = 'michaelj@example.com';

-- 4. birthday'i '1992-11-12' olan satırı sil
DELETE FROM employee WHERE birthday = '1992-11-12';

-- 5. id'si 5 olan satırı sil
DELETE FROM employee WHERE id = 5;
