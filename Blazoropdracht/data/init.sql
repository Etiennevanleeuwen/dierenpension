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
CREATE TABLE Cages (
                       Id INTEGER PRIMARY KEY AUTOINCREMENT,
                       Name TEXT NOT NULL,
                       Size TEXT NOT NULL CHECK (Size IN ('S', 'M', 'L'))
    );
CREATE TABLE Reservations (
                              Id INTEGER PRIMARY KEY AUTOINCREMENT,
                              PetId INTEGER NOT NULL,
                              CageId INTEGER NOT NULL,
                              StartDate TEXT NOT NULL,
                              EndDate TEXT NOT NULL,
                              FOREIGN KEY (PetId) REFERENCES Pets(Id),
                              FOREIGN KEY (CageId) REFERENCES Cages(Id)
);
INSERT INTO Clients (Id, Name, Address, Zipcode, City) VALUES
                                                           (1, 'Bart van Kuik', 'Hoofdstraat 1', '1234 AB', 'Amsterdam'),
                                                           (2, 'Goedele Liekens', 'Keizersgracht 42', '5678 CD', 'Rotterdam'),
                                                           (3, 'Jan Jansen', 'Markt 7', '9012 EF', 'Utrecht');
INSERT INTO Pets (Id, Name, ClientId) VALUES
                                          (1, 'Snuf', 1),
                                          (2, 'Rakker', 2);
INSERT INTO Cages (Id, Name, Size) VALUES
                                       (1, 'Kleine kooi', 'S'),
                                       (2, 'Middelste kooi', 'M'),
                                       (3, 'Grote kooi', 'L');