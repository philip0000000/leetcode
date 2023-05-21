-- 1st
# Write your MySQL query statement below
SELECT IFNULL(unique_id, NULL) AS unique_id, name
FROM Employees e
LEFT JOIN EmployeeUNI eu ON e.id = eu.id;

-- 2nd
# Write your MySQL query statement below
SELECT unique_id AS unique_id, name
FROM Employees e
LEFT JOIN EmployeeUNI eu ON e.id = eu.id;
