/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
DELETE FROM Person
WHERE email IN
  (SELECT email
  FROM Person
  GROUP BY email
  HAVING COUNT(email) > 1) AND
  id NOT IN
  (SELECT MIN(id)
  FROM Person
  GROUP BY email)
;
