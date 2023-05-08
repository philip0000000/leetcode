--1st
/* Write your T-SQL query statement below */
SELECT *
FROM Patients
WHERE conditions LIKE '%[^a-zA-Z]DIAB1%' OR conditions LIKE 'DIAB1%';

--2nd
/* Write your T-SQL query statement below */
SELECT *
FROM Patients
WHERE conditions LIKE '% DIAB1%' OR conditions LIKE 'DIAB1%';
