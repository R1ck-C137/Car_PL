--Создание таблиц в БД
create table Customers
(
Id bigint identity(1,1) not null primary key,
Name varchar(50) not null,
)

create table Orders
(
ID bigint identity(1,1) not null primary key,
CustomerId bigint not null
)
--Вставка значений в таблицу Customers
insert Customers values('Max')
insert Customers values('Pavel')
insert Customers values('Ivan')
insert Customers values('Leonid')
--Вставка значений в таблицу Orders
insert Orders values(2)
insert Orders values(4)

SELECT
  c.Name
FROM Customers c
LEFT JOIN Orders o ON c.Id = o.CustomerId
WHERE o.CustomerId IS NULL
ORDER BY Name