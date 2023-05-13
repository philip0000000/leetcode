/* 1st */
SELECT
CASE
  WHEN EXISTS(
      SELECT num
      FROM MyNumbers
      GROUP BY num
      HAVING COUNT(num) = 1
      ORDER BY num DESC
      LIMIT 1
    )
    THEN (
      SELECT num
      FROM MyNumbers
      GROUP BY num
      HAVING COUNT(num) = 1
      ORDER BY num DESC
      LIMIT 1
    )
  ELSE NULL
END AS num;

/* 2nd 50%~ */
# Write your MySQL query statement below
SELECT MAX(num) AS num
FROM
  (SELECT num
  FROM MyNumbers
  GROUP BY num
  HAVING COUNT(num) = 1) second;
