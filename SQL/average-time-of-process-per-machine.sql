# Write your MySQL query statement below
SELECT machine_id, ROUND(AVG(processing_time), 3) AS processing_time
FROM
  (SELECT t1.machine_id, t2.timestamp - t1.timestamp AS processing_time
  FROM
    (SELECT * FROM Activity WHERE activity_type = 'start') AS t1
  LEFT JOIN
    (SELECT * FROM Activity WHERE activity_type = 'end') AS t2
  ON t1.machine_id = t2.machine_id AND t1.process_id = t2.process_id
  GROUP BY t1.machine_id, t1.process_id) AS t3
GROUP BY machine_id;
