select * from LMS_BOOK_DETAILS;
select * from LMS_BOOK_ISSUE;
select * from LMS_FINE_DETAILS;
select * from LMS_MEMBERS;
select * from LMS_SUPPLIERS_DETAILS;

-- 1,3,4,5,6,7,8,9,10,11,12,13,14,16





-- Problem#16:
-- Write a query to display the supplier id, supplier name and contact. If phone number is null then display ‘No’ else display ‘Yes’ with alias name “PHONENUMAVAILABLE”. Hint: Use ISNULL.


select SUPPLIER_ID,SUPPLIER_NAME,CONTACT ,
CASE
	WHEN CONTACT IS NULL THEN 'NO'
	ELSE 'YES'
END AS 'PHONENUM AVAILABLE'
from LMS_SUPPLIERS_DETAILS;


-- Display the book code,book name and suplier name of the books in library

select b.book_code,b.book_title, s.supplier_name 
from LMS_BOOK_DETAILS as b join  lms_suppliers_details as s on b.SUPPLIER_ID=s.SUPPLIER_ID;






