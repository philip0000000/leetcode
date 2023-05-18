# Write your MySQL query statement below
SELECT t1.employee_id, name, reports_count, average_age
FROM
  (SELECT reports_to AS employee_id, name AS n, COUNT(reports_to) AS reports_count, ROUND(AVG(age)) AS average_age
  FROM Employees t2
  GROUP BY reports_to) AS t1
LEFT JOIN Employees t3
ON t1.employee_id = t3.employee_id
WHERE t1.employee_id IS NOT NULL
ORDER BY employee_id;
