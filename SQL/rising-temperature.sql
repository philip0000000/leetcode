/* Write your T-SQL query statement below */
SELECT w.id
FROM weather w, weather w2
WHERE w.temperature > (
  SELECT w2.temperature
  WHERE w2.recordDate = DATEADD(day, -1, w.recordDate)
);
