SELECT DISTINCT city
FROM station
WHERE CITY LIKE '[AEIOU]%' AND CITY LIKE '%[AEIOU]';