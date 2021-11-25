INSERT INTO Book(Title)
VALUES ('The Name of the Wind'), ('Northern Lights'), ('The Help');

INSERT INTO Author(AuthorName)
VALUES ('Patrick Rothfuss'), ('Philip Pullman'), ('Kathryn Stockett');


INSERT INTO AuthorBook(BookId, AuthorId)
VALUES (1,1),(2,2), (3,3);


SELECT Author.AuthorName, Book.Title
FROM Author
INNER JOIN AuthorBook AB ON Author.Id = AB.AuthorId
INNER JOIN Book ON AB.Id = Book.Id;




INSERT INTO LibraryUser(UserName, Password)
VALUES ('Jasmin', 'Password123');
INSERT INTO LibraryUser(UserName, Password)
VALUES ('Michael', 'Password456');


INSERT INTO Loan (BookId,UserId)
VALUES (1,1), (2,1);

INSERT INTO Loan (BookId, UserId)
Values (3,2)



SELECT Title
From Book
INNER JOIN Loan on Book.Id = Loan.Id;

