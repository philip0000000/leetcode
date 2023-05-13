# Write your MySQL query statement below
SELECT project_id, ROUND(AVG(emp.experience_years), 2) AS average_years
FROM Project proj
LEFT JOIN Employee emp ON proj.employee_id = emp.employee_id
GROUP BY proj.project_id;
