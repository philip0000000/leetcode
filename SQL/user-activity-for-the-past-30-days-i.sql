SELECT activity_date AS day, COUNT(DISTINCT user_id) AS active_users
FROM Activity
WHERE YEAR(activity_date) AND ((MONTH(activity_date) = 7 AND DAY(activity_date) <= 27) OR (MONTH(activity_date) = 6 AND DAY(activity_date) >= 28))
GROUP BY activity_date;
