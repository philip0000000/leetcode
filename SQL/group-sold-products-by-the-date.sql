# Write your MySQL query statement below
SELECT sell_date, COUNT(sell_date) AS num_sold, GROUP_CONCAT(product ORDER BY product) AS products
FROM (
  SELECT DISTINCT *
  FROM Activities
) AS t
GROUP BY sell_date
ORDER BY sell_date;
