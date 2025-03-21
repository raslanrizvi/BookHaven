Select * From OrderItems

SELECT o.*, b.Title FROM OrderItems o INNER JOIN Books b ON o.BookId = b.ID WHERE OrdId=1005 ORDER BY ID DESC

SELECT * FROM Orders ORDER BY ID DESC

SELECT * FROM Orders WHERE ID='inStore' or OrdType LIKE '%inStore%' or PytMethod LIKE '%inStore%' or Status LIKE '%inStore%'

SELECT * FROM Books

SELECT * FROM Books WHERE Title LIKE '%The%' OR ISBN LIKE '%The%' OR Author LIKE '%The%'

SELECT b.*, s.Name, g.Genre FROM ((Books b INNER JOIN Supplier s ON b.supID=s.ID) INNER JOIN BookGenre g ON b.GenreID=g.ID) WHERE Title LIKE '%ABC%' OR ISBN LIKE '%ABC%' OR Author LIKE '%ABC%' OR Genre LIKE '%ABC%' OR Name LIKE '%ABC%'



