CREATE TABLE Rendez_vous(
   Date_heure_id VARCHAR(50),
   Date_heure_Rdv DATETIME,
   V�terinaire_attribu� VARCHAR(50) NOT NULL,
   Etat_rdv VARCHAR(50) NOT NULL,
   PRIMARY KEY(Date_heure_id)
);