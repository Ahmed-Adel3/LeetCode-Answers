# Write your MySQL query statement below
select s.price, s.year, p.product_name
from Sales as s
inner join Product as p
on s.product_id = p.product_id