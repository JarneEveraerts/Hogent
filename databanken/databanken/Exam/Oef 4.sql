select o.ship_name,s.company,o.id
from shippers s ,orders o
where o.shipper_id=s.id
order by o.customer_id asc, o.id asc;