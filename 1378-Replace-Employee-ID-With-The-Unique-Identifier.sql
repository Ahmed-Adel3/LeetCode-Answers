# Write your MySQL query statement below
select EmployeeUNI.unique_id , Employees.name
from EmployeeUNI
right outer join Employees
on EmployeeUNI.id = Employees.id