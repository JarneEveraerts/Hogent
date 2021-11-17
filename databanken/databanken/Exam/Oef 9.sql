update employees 
set fax_number = concat('+1',fax_number)
where city = 'Redmond' or city = 'Kirkland' or city = 'Bellevue';