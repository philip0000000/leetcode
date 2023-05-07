/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT CAST(CEILING(
            AVG(CAST(salary AS FLOAT)) -
            AVG(CAST(REPLACE(CAST(salary AS VARCHAR(50)), '0', '') AS FLOAT))
        ) AS INT)
FROM EMPLOYEES;
