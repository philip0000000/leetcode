/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT COUNT(city) - COUNT(DISTINCT city) AS diff
FROM station;
