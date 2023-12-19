CREATE TABLE Dons(
   Dons_id VARCHAR(50),
   Montants DECIMAL(15,2) NOT NULL,
   Date_dons DATE,
   Option_paiement VARCHAR(50),
   Statuts VARCHAR(50),
   PRIMARY KEY(Dons_id)
);