/*
Enter your query here.
*/
SELECT ROUND(MAX(LAT_N), 4)
FROM Station
WHERE LAT_N < 137.2345;
