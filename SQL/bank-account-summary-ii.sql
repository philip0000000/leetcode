/* Write your T-SQL query statement below */
SELECT name, SUM(amount) AS balance
FROM Users u
LEFT JOIN Transactions t
ON u.account = t.account
GROUP BY name
HAVING SUM(amount) > 10000;
