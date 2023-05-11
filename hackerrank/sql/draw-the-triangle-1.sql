/*
Enter your query here.
*/

SET @FOO = REPEAT('* ', 20);
SET @FOO = SUBSTRING(@FOO, 1, LENGTH(@FOO) - 1);

DELIMITER //
CREATE PROCEDURE P(IN num INTEGER)
BEGIN
    DECLARE var_name INT DEFAULT 1;
    WHILE var_name <= num DO
        SELECT @FOO;
        SET @FOO = SUBSTRING(@FOO, 1, LENGTH(@FOO) - 2);
        SET var_name = var_name + 1;
    END WHILE;
END //
DELIMITER ;

CALL P(20);


