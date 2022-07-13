CREATE FUNCTION tip_count_update()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
	UPDATE business
	SET num_tips=num_tips+1
	WHERE NEW.business_id=business.business_id;

	UPDATE users
	SET total_tip_count=total_tip_count+1
	WHERE NEW.user_id=users.user_id;

	RETURN NEW;
END;
$$;

CREATE FUNCTION tip_like_update()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
	UPDATE users
	SET total_tip_like=total_tip_like+1
	WHERE NEW.user_id=users.user_id;

	RETURN NEW;
END;
$$;

CREATE FUNCTION checkin_count_update()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
	UPDATE business
	SET num_checkins=num_checkins+1
	WHERE NEW.business_id=business.business_id;

	RETURN NEW;
END;
$$;

CREATE TRIGGER tip_count_trigger AFTER INSERT
ON business_tip
FOR EACH ROW
EXECUTE PROCEDURE tip_count_update();

CREATE TRIGGER tip_like_trigger AFTER UPDATE OF likes
ON business_tip
FOR EACH ROW
EXECUTE PROCEDURE tip_like_update();

CREATE TRIGGER checkin_count_trigger AFTER INSERT
ON business_checkin
FOR EACH ROW
EXECUTE PROCEDURE checkin_count_update();