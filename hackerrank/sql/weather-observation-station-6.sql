/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT DISTINCT city
FROM station
WHERE SUBSTRING(city, 1, 1) = 'a' or
      SUBSTRING(city, 1, 1) = 'e' or
      SUBSTRING(city, 1, 1) = 'i' or
      SUBSTRING(city, 1, 1) = 'o' or
      SUBSTRING(city, 1, 1) = 'u';


--------------------------------------------------
SELECT city
FROM station
WHERE city LIKE '[AEIOU]%';
