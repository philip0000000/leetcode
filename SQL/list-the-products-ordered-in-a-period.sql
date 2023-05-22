-- 1st
# Write your MySQL query statement below
SELECT DISTINCT p.product_name, t1.unit
FROM
  (SELECT product_id, SUM(unit) AS unit
  FROM Orders
  WHERE YEAR(order_date) = 2020 AND MONTH(order_date) = 2
  GROUP BY product_id) AS t1
LEFT JOIN Products p ON p.product_id = t1.product_id
WHERE t1.unit >= 100;

-- 2nd 30%~
# Write your MySQL query statement below
SELECT p.product_name, SUM(o.unit) AS unit
FROM Orders o
LEFT JOIN Products p ON p.product_id = o.product_id
WHERE YEAR(o.order_date) = 2020 AND MONTH(o.order_date) = 2
GROUP BY o.product_id
HAVING SUM(o.unit) >= 100;
