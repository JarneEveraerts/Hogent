select p.product_name,p.list_price
from products p
order by p.list_price desc limit 10;