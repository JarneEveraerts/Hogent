select p.id,p.product_name,p.standard_cost
from products p
where p.standard_cost < 15.0001 and p.standard_cost >4.9999;