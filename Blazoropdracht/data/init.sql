CREATE TABLE Clients (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         Name TEXT NOT NULL,
                         Address TEXT NOT NULL,
                         Zipcode TEXT NOT NULL,
                         City TEXT NOT NULL
);
CREATE TABLE Pets (
                      Id INTEGER PRIMARY KEY AUTOINCREMENT,
                      Name TEXT NOT NULL,
                      ClientId INTEGER NOT NULL,
                      FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);
INSERT INTO Clients (Id, Name, Address, Zipcode, City) VALUES
                                                           (1, 'Bart van Kuik', 'Hoofdstraat 1', '1234 AB', 'Amsterdam'),
                                                           (2, 'Goedele Liekens', 'Keizersgracht 42', '5678 CD', 'Rotterdam'),
                                                           (3, 'Jan Jansen', 'Markt 7', '9012 EF', 'Utrecht');
INSERT INTO Pets (Id, Name, ClientId) VALUES
                                          (1, 'Snuf', 1),
                                          (2, 'Rakker', 2);