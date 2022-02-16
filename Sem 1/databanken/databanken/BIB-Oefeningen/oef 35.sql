update uitleen
set datum = adddate(datum,interval 5 day)
where klant_id = 5