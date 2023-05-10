/*
Enter your query here.
*/
SELECT ROUND(LONG_W, 4)
FROM station
WHERE LAT_N > 38.7780
ORDER BY LAT_N ASC
LIMIT 1;
