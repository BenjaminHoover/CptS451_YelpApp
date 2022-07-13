psql -U postgres -c "DROP DATABASE milestone2db"
psql -U postgres -c "CREATE DATABASE milestone2db"

psql -U postgres -d milestone2db -f Skyrmion_RELATIONS_v2.sql

psql -U postgres -d milestone2db -f TEST_INSERT.sql

#psql -U postgres -d milestone2db -f ./data/user.sql
#psql -U postgres -d milestone2db -f ./data/business.sql
#psql -U postgres -d milestone2db -f ./data/checkins.sql
#psql -U postgres -d milestone2db -f ./data/tips.sql
#psql -U postgres -d milestone2db -f ./data/business_hours.sql
#psql -U postgres -d milestone2db -f ./data/friends.sql
#psql -U postgres -d milestone2db -f ./data/business_attrs.sql
#psql -U postgres -d milestone2db -f ./data/business_good_for_meal.sql
#psql -U postgres -d milestone2db -f ./data/business_ambience.sql
#psql -U postgres -d milestone2db -f ./data/business_parking.sql
#psql -U postgres -d milestone2db -f ./data/business_category.sql

psql -U postgres -d milestone2db -f Skyrmion_UPDATE.sql
psql -U postgres -d milestone2db -f Skyrmion_TRIGGER.sql
