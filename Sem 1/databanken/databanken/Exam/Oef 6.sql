select concat('Order nr ',p.id,' werd ingevoerd op ',p.submitted_date) as 'Invoeren aankooporders'
from purchase_orders p
order by p.id asc;