UPDATE users SET
	longitude=1,
	latitude=1
WHERE user_id='4XChL029mKr5hydo79Ljxg';

SELECT business.business_id, (7917.6 * ASIN(SQRT(POW(SIN(((business.latitude-users.latitude)*PI()/360), 2) +
	COS(users.latitude*PI()/180)*COS(business.latitude*PI()/180) * POW(SIN((business.longitude-users.longitude)*PI()/360), 2))))
FROM users, business
WHERE users.user_id='4XChL029mKr5hydo79Ljxg' AND business.business_id='gnKjwL_1w79qoiV3IC_xQQ';

SELECT f.name, business.name, business_tip.body, business_tip.date_time
FROM business_tip
INNER JOIN
	(SELECT name, user_id
	FROM friends, users
	WHERE '5XChL029mKr5hydo79Ljxa' = friends_of AND user_id = friends_with) as f
ON business_tip.user_id = f.user_id
INNER JOIN business
ON business.business_id = business_tip.business_id
WHERE (f.user_id, business_tip.date_time) IN
	(SELECT business_tip.user_id, MAX(business_tip.date_time) as date
	FROM business_tip
	GROUP BY business_tip.user_id);

SELECT f.name, business.name, business_tip.body, business_tip.date_time
FROM business_tip
INNER JOIN
	(SELECT name, user_id
	FROM friends, users
	WHERE '5XChL029mKr5hydo79Ljxa' = friends_of AND user_id = friends_with) as f
ON business_tip.user_id = f.user_id
INNER JOIN business
ON business.business_id = business_tip.business_id
WHERE business.business_id = 'gnKjwL_1w79qoiV3IC_xQQ';