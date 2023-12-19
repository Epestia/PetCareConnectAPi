CREATE TABLE Rendez_vous(
   Date_heure_id VARCHAR(50),
   Date_heure_Rdv DATETIME,
   Véterinaire_attribué VARCHAR(50) NOT NULL,
   Etat_rdv VARCHAR(50) NOT NULL,
   PRIMARY KEY(Date_heure_id)
);