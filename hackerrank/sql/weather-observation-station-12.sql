/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT DISTINCT city
FROM station
WHERE city NOT LIKE '[AIOUE]%' AND city NOT LIKE '%[AIOUE]';