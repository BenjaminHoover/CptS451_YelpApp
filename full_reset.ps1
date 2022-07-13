# Set connection parameters here
$env:PGCLIENTENCODING = 'utf8'
$env:PGUSER = 'postgres'
$env:PGPASSWORD = 'jkls'
$env:PGDATABASE = 'milestone2db'


# temporarily unset (but keep) database name env var
$db = $env:PGDATABASE
$env:PGDATABASE = $null

psql -c "DROP DATABASE $db"
psql -c "CREATE DATABASE $db"

$env:PGDATABASE = $db

psql -f Skyrmion_RELATIONS_v2.sql

psql -f ./data/user.sql
psql -f ./data/business.sql
psql -f ./data/checkins.sql
psql -f ./data/tips.sql
psql -f ./data/business_hours.sql
psql -f ./data/friends.sql
psql -f ./data/business_attrs.sql
psql -f ./data/business_good_for_meal.sql
psql -f ./data/business_ambience.sql
psql -f ./data/business_parking.sql
psql -f ./data/business_category.sql

psql -f Skyrmion_UPDATE.sql
psql -f Skyrmion_TRIGGER.sql