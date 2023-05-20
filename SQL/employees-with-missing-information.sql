SELECT *
FROM
  (SELECT employee_id FROM Employees 
  UNION
  SELECT employee_id FROM Salaries) AS t2
WHERE employee_id NOT IN
  (SELECT e.employee_id
  FROM Employees e
  JOIN Salaries s
  ON e.employee_id = s.employee_id)
ORDER BY employee_id;
