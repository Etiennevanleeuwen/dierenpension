CREATE TABLE Clients (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         Name TEXT NOT NULL,
                         Address TEXT NOT NULL,
                         Zipcode TEXT NOT NULL,
                         City TEXT NOT NULL,
                         Phone TEXT NOT NULL,
                         Email TEXT NOT NULL
);
CREATE TABLE Pets (
                      Id INTEGER PRIMARY KEY AUTOINCREMENT,
                      Name TEXT NOT NULL,
                      ClientId INTEGER NOT NULL,
                      Diersoort TEXT NOT NULL CHECK (Diersoort IN ('Hond', 'Kat', 'Cavia', 'Konijn', 'Vogel', 'Overig')),
                      Ras TEXT NOT NULL,
                      GebruiktMedicijnen INTEGER NOT NULL DEFAULT 0,
                      MedicijnBeschrijving TEXT,
                      SpeeltGoedMetAndereHonden INTEGER NOT NULL DEFAULT 0,
                      IsGevaarlijk INTEGER NOT NULL DEFAULT 0,
                      GedragsOpmerkingen TEXT,
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
INSERT INTO Clients (Id, Name, Address, Zipcode, City, Phone, Email) VALUES
                                                                         (1, 'Bart van Kuik', 'Hoofdstraat 1', '1234 AB', 'Amsterdam', '0612345678', 'bart.vankuik@example.com'),
                                                                         (2, 'Goedele Liekens', 'Keizersgracht 42', '5678 CD', 'Rotterdam', '0623456789', 'goedele.liekens@example.com'),
                                                                         (3, 'Jan Jansen', 'Markt 7', '9012 EF', 'Utrecht', '0634567890', 'jan.jansen@example.com');
INSERT INTO Pets (Id, Name, ClientId, Diersoort, Ras, GebruiktMedicijnen, MedicijnBeschrijving, SpeeltGoedMetAndereHonden, IsGevaarlijk, GedragsOpmerkingen) VALUES
                                                                                                                                                                 (1, 'Snuf', 1, 'Hond', 'Labrador', 0, NULL, 1, 0, NULL),
                                                                                                                                                                 (2, 'Rakker', 2, 'Kat', 'Europese korthaar', 1, 'Elke ochtend 1 tablet allergiemedicatie', 0, 0, 'Verstopt zich bij drukte');
INSERT INTO Cages (Id, Name, Size) VALUES
                                       (1, 'Kleine kooi', 'S'),
                                       (2, 'Middelste kooi', 'M'),
                                       (3, 'Grote kooi', 'L');
CREATE TABLE Users (
                       Id INTEGER PRIMARY KEY AUTOINCREMENT,
                       Email TEXT NOT NULL UNIQUE,
                       Password TEXT NOT NULL,
                       Role TEXT NOT NULL CHECK (Role IN ('user', 'admin'))
);
INSERT INTO Users (Id, Email, Password, Role) VALUES
                                                  (1, 'admin@example.com', 'welkom123', 'admin'),
                                                  (2, 'user@example.com', 'welkom123', 'user');