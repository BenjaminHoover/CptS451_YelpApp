--{"average_stars": 3.63, "cool": 16, "fans": 4, "friends": [], "funny": 22, "name": "Jenna", "tipcount": 0, "useful": 48, "user_id": "4XChL029mKr5hydo79Ljxg", "yelping_since": "2013-02-21 22:29:06"}
--{"average_stars": 4.39, "cool": 15319, "fans": 696, "friends": [], "funny": 19356, "name": "Keane", "tipcount": 0, "useful": 13311, "user_id": "TEtzbpgA2BFBrC0y0sCbfw", "yelping_since": "2006-02-15 18:29:35"}
--{"business_id": "gnKjwL_1w79qoiV3IC_xQQ", "name": "Musashi Japanese Restaurant", "address": "10110 Johnston Rd, Ste 15", "city": "Charlotte", "state": "NC", "postal_code": "28210", "latitude": 35.092564, "longitude": -80.859132, "stars": 4.0, "review_count": 170, "is_open": 1, "attributes": {"GoodForKids": "True", "NoiseLevel": "average", "RestaurantsDelivery": "False", "GoodForMeal": {"dessert": "False", "latenight": "False", "lunch": "True", "dinner": "True", "brunch": "False", "breakfast": "False"}, "Alcohol": "beer_and_wine", "Caters": "False", "WiFi": "no", "RestaurantsTakeOut": "True", "BusinessAcceptsCreditCards": "True", "Ambience": {"romantic": "False", "intimate": "False", "touristy": "False", "hipster": "False", "divey": "False", "classy": "False", "trendy": "False", "upscale": "False", "casual": "True"}, "BusinessParking": {"garage": "False", "street": "False", "validated": "False", "lot": "True", "valet": "False"}, "RestaurantsTableService": "True", "RestaurantsGoodForGroups": "True", "OutdoorSeating": "False", "HasTV": "True", "BikeParking": "True", "RestaurantsReservations": "True", "RestaurantsPriceRange2": "2", "RestaurantsAttire": "casual"}, "categories": "Sushi Bars, Restaurants, Japanese", "hours": {"Monday": "17:30-21:30", "Wednesday": "17:30-21:30", "Thursday": "17:30-21:30", "Friday": "17:30-22:0", "Saturday": "17:30-22:0", "Sunday": "17:30-21:0"}}
--{"business_id": "Y6iyemLX_oylRpnr38vgMA", "name": "Vita Bella Fine Day Spa", "address": "5940 W Union Hills Dr", "city": "Glendale", "state": "AZ", "postal_code": "85308", "latitude": 33.6548146, "longitude": -112.1885676, "stars": 5.0, "review_count": 8, "is_open": 0, "attributes": {"RestaurantsPriceRange2": "2", "ByAppointmentOnly": "True", "BusinessParking": {"garage": "False", "street": "False", "validated": "False", "lot": "True", "valet": "False"}, "BusinessAcceptsCreditCards": "True", "BikeParking": "False"}, "categories": "Nail Salons, Beauty & Spas, Day Spas", "hours": {"Tuesday": "12:0-18:0", "Wednesday": "10:0-18:0", "Thursday": "12:0-18:0", "Friday": "10:0-17:0", "Saturday": "10:0-14:0"}}

INSERT INTO business
	(business_id, name, address, city, state, postal_code, latitude, longitude, stars, is_open)
VALUES
	('gnKjwL_1w79qoiV3IC_xQQ', 'Musashi Japanese Restaurant', '10110 Johnston Rd, Ste 15', 'Charlotte', 'NC', '28210', 35.092564, -80.859132, 4.0, TRUE),
	('gnKjwL_1w79qoiV3IC_xQS', 'another Japanese Restaurant', '10110 Johnston Rd, Ste 15', 'Charlotte', 'NC', '28210', 35.092564, -80.859132, 4.0, TRUE),
	('gnKjwL_1w79qoiV3IC_xQD', 'a different another Japanese Restaurant', '10110 Johnston Rd, Ste 15', 'Charlotte', 'NC', '28210', 35.092564, -80.859132, 4.0, TRUE),
	('Y6iyemLX_oylRpnr38vgMA', 'Vita Bella Fine Day Spa', '5940 W Union Hills Dr', 'Glendale', 'AZ', '85308', 33.6548146, -112.1885676, 5.0, FALSE);

INSERT INTO users
	(average_stars, cool, fans, funny, name, useful, user_id)
VALUES
	(3.63, 16, 4, 22, 'Jenna', 48, '4XChL029mKr5hydo79Ljxg'),
	(3.63, 16, 4, 22, 'Jenna2', 48, '5XChL029mKr5hydo79Ljxa'),
	(4.39, 15319, 696, 19356, 'Keane', 11311, 'TEtzbpgA2BFBrC0y0sCbfw');

INSERT INTO business_checkin
	(business_id, date_time)
VALUES
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 18:29:35'),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 19:29:35'),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 20:29:35'),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-03-15 18:29:35'),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-04-15 18:29:35'),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-05-15 18:29:35'),
	('Y6iyemLX_oylRpnr38vgMA', '2006-02-15 18:29:35'),
	('Y6iyemLX_oylRpnr38vgMA', '2006-05-15 18:29:35');

INSERT INTO business_attrs
	(business_id, attr_name, attr_value)
VALUES
	('gnKjwL_1w79qoiV3IC_xQQ', 'cool', 'like, super man'),
	('gnKjwL_1w79qoiV3IC_xQS', 'cool but weird', 'like, super man'),
	('gnKjwL_1w79qoiV3IC_xQD', 'cool but strange', 'like, super man'),
	('Y6iyemLX_oylRpnr38vgMA', 'lame', 'really, really lame');


INSERT INTO business_tip
	(business_id, date_time, user_id, body, likes)
VALUES
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 18:29:35', '4XChL029mKr5hydo79Ljxg', 'Test successful', 1),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 19:29:35', 'TEtzbpgA2BFBrC0y0sCbfw', 'Subject did well... Enough', 2),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-02-15 20:29:35', '4XChL029mKr5hydo79Ljxg', 'Yes', 3),
	('gnKjwL_1w79qoiV3IC_xQQ', '2006-03-15 18:29:35', '4XChL029mKr5hydo79Ljxg', 'No', 4),
	('Y6iyemLX_oylRpnr38vgMA', '2006-02-15 18:29:35', '4XChL029mKr5hydo79Ljxg', 'Maybe So', 5),
	('Y6iyemLX_oylRpnr38vgMA', '2006-03-15 18:29:35', 'TEtzbpgA2BFBrC0y0sCbfw', 'Hello', 6),
	('Y6iyemLX_oylRpnr38vgMA', '2006-05-15 18:29:35', '4XChL029mKr5hydo79Ljxg', 'Goodbye', 7);

INSERT INTO friends
	(friends_of, friends_with)
VALUES
	('TEtzbpgA2BFBrC0y0sCbfw', '4XChL029mKr5hydo79Ljxg'),
	('5XChL029mKr5hydo79Ljxa', '4XChL029mKr5hydo79Ljxg'),
	('5XChL029mKr5hydo79Ljxa', 'TEtzbpgA2BFBrC0y0sCbfw');

