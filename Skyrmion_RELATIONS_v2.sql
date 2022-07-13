CREATE TABLE users (
    user_id CHAR(22) PRIMARY KEY,
    name VARCHAR,
    average_stars FLOAT,
    yelping_since TIMESTAMP,
    total_tip_count INT,
    total_tip_like INT,
    longitude FLOAT,
    latitude FLOAT,
    useful INT,
    funny INT,
    cool INT,
    fans INT
);
CREATE TABLE friends (
    friends_of CHAR(22),
    friends_with CHAR(22),
    primary key (friends_of, friends_with),
    foreign key (friends_of) references users(user_id),
    foreign key (friends_with) references users(user_id)
);
CREATE TABLE business (
    business_id CHAR(22) PRIMARY KEY,
    name VARCHAR,
    num_tips INTEGER,
    num_checkins INTEGER,
    is_open boolean,
    stars FLOAT,
    address VARCHAR,
    city VARCHAR,
    state CHAR(2),
    postal_code CHAR(5),
    latitude FLOAT,
    longitude FLOAT
);
create table business_hours (
    business_id CHAR(22),
    day_of_week CHAR(2),
    close_time float,
    open_time float,
    primary key (business_id, day_of_week),
    foreign key (business_id) references business(business_id)
);
create table business_attrs (
    business_id CHAR(22),
    attr_name TEXT,
    attr_value TEXT,
    primary key (business_id, attr_name),
    foreign key (business_id) references business(business_id)
);
create table business_good_for_meal(
    business_id CHAR(22),
    meal_type TEXT,
    primary key (business_id, meal_type),
    foreign key (business_id) references business(business_id)
);
create table business_ambience (
    business_id CHAR(22),
    ambience text,
    primary key (business_id, ambience),
    foreign key (business_id) references business(business_id)
);
create table business_parking (
    business_id CHAR(22),
    parking_type TEXT,
    primary key (business_id, parking_type),
    foreign key (business_id) references business(business_id)
);
create table business_checkin (
    business_id CHAR(22),
    date_time timestamp,
    primary key (business_id, date_time),
    foreign key (business_id) references business(business_id)
);
create table business_tip (
    business_id CHAR(22),
    user_id CHAR(22),
    date_time timestamp,
    body TEXT,
    likes int,
    primary key (business_id, user_id, date_time),
    foreign key (business_id) references business(business_id),
    foreign key (user_id) references users(user_id)
);
create table business_category (
    business_id CHAR(22),
    category_name VARCHAR,
    primary key (business_id, category_name),
    foreign key (business_id) references business(business_id)
);