/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT s.name
FROM students s
WHERE s.Marks > 75
ORDER BY SUBSTRING(s.name, LEN(s.name)-2, 3), s.id ASC;
