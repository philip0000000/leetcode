/* Write your T-SQL query statement below */
SELECT Employee.name AS Employee
FROM Employee
WHERE Employee.managerId IS NOT NULL AND
Employee.salary > (SELECT temp.salary FROM Employee AS temp WHERE temp.id = Employee.managerId);
