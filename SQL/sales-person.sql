# Write your MySQL query statement below
SELECT name
FROM SalesPerson
WHERE name NOT IN
(SELECT name
FROM SalesPerson sp
LEFT JOIN Orders ord ON sp.sales_id = ord.sales_id
WHERE ord.com_id = (SELECT com_id FROM Company WHERE name = 'RED'));
