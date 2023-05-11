/*
Enter your query here.
*/


SET @FOO = '*'; 

DELIMITER //
CREATE PROCEDURE P(IN num INTEGER)
BEGIN
    DECLARE var_name INT DEFAULT 1;
    WHILE var_name <= num DO
        SELECT @FOO;
        SET @FOO = CONCAT(@FOO, ' *');
        SET var_name = var_name + 1;
    END WHILE;
END //
DELIMITER ;

CALL P(20);





