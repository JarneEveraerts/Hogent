select distinct o.ship_name as 'Klantnaam'
from orders o
group by o.ship_name
having count(o.id) > 0;