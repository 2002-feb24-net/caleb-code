use Chinook;
go

 -- 1. List all customers (full names, customer ID, and country) who are not in the US
 select FirstName, LastName, CustomerId, Country
 from Customer
 where Country != 'USA'
 order by Country;
 -- 2. List all customers from brazil
 select *
 from Customer
 where Country = 'Brazil';
 -- 3. List all sales agents
 select *
 from Employee
 order by LastName;
 -- 4. Show a list of all countries in billing addresses on invoices.
 select BillingCountry
 from Invoice
 order by BillingCountry;
 -- 5. How many invoices were there in 2009, and what was the sales total for that year?
 select COUNT(InvoiceId) as 'Invoice Count 2009', SUM(Total) as 'Sales Total 2009'
 from Invoice
 where InvoiceDate like '%2009%';
 -- 6. How many line items were there for invoice #37?
 select Quantity
 from InvoiceLine
 where InvoiceLineId = 37;
 -- 7. How many invoices per country?
 select BillingCountry, count(BillingCountry) as Invoices
 from Invoice
 group by BillingCountry;
 -- 8. Show total sales per country, ordered by highest sales first.
 select BillingCountry, count(InvoiceId) as 'Sales Count'
 from Invoice
 group by BillingCountry
 order by count(InvoiceId) desc;