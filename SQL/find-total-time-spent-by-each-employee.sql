/* 1st */
# Write your MySQL query statement below
SELECT day, emp_id, SUM(total_time) AS total_time
FROM (
  SELECT event_day AS day, emp_id, out_time - in_time AS total_time
  FROM Employees
  ) AS temp
GROUP BY day, emp_id;

/* 2nd */
# Write your MySQL query statement below
SELECT event_day AS day, emp_id, SUM(out_time - in_time) AS total_time
FROM Employees
GROUP BY day, emp_id;
