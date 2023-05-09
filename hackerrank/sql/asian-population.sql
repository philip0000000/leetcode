SELECT SUM(city.population)
FROM city
LEFT JOIN country ON city.CountryCode = country.Code
WHERE country.CONTINENT = 'Asia';
