# Write your MySQL query statement below
SELECT product_id, ROUND(SUM(pp) / SUM(units), 2) AS average_price
FROM
  (SELECT pri.product_id, us.units * pri.price AS pp, units
  FROM Prices pri
  LEFT JOIN UnitsSold us ON pri.product_id = us.product_id
  WHERE us.purchase_date >= pri.start_date AND us.purchase_date <= pri.end_date) AS temp
GROUP BY product_id
;
