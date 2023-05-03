/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT city
FROM station
WHERE id % 2 = 0
GROUP BY city;
