SELECT business.business_id, COALESCE(a.value, 0) AS num_checkins,
	COALESCE(b.value, 0) AS num_tips
INTO temp_business
FROM business
FULL JOIN
	(SELECT business_id, COUNT(date_time) AS value
	FROM business_checkin
	GROUP BY business_id) a
ON business.business_id = a.business_id
FULL JOIN
	(SELECT business_id, COUNT(date_time) AS value
	FROM business_tip
	GROUP BY business_id) b
ON business.business_id = b.business_id;

SELECT users.user_id, COUNT(business_tip.likes) AS total_tip_count,
	COALESCE(SUM(business_tip.likes), 0) AS total_tip_like
INTO temp_users
FROM users
FULL JOIN business_tip
	ON users.user_id = business_tip.user_id
GROUP BY users.user_id;

UPDATE business
SET
	num_tips=temp_business.num_tips,
	num_checkins=temp_business.num_checkins
FROM temp_business
WHERE business.business_id=temp_business.business_id;

UPDATE users
SET
	total_tip_count=temp_users.total_tip_count,
	total_tip_like=temp_users.total_tip_like
FROM temp_users
WHERE users.user_id=temp_users.user_id;

DROP TABLE temp_business;
DROP TABLE temp_users;