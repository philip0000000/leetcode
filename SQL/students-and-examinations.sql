SELECT student_id, student_name, subject_name, COUNT(subject_name)-1 AS attended_exams
FROM
  (SELECT *
  FROM
    (SELECT s.student_id, s.student_name, e.subject_name
    FROM Examinations e
    LEFT JOIN Students s ON s.student_id = e.student_id) AS t2
  UNION ALL
  SELECT s.student_id, s.student_name, sub.subject_name
  FROM Students s
  CROSS JOIN Subjects sub) AS t3
GROUP BY student_id, subject_name
ORDER BY student_id, subject_name;
