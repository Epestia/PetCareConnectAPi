CREATE TABLE Utilisateurs(
   Utilisateur_id VARCHAR(50),
   Pseudo_utilisateur VARCHAR(50) NOT NULL,
   Prenom_utilisateur VARCHAR(50),
   Nom_utilisateur VARCHAR(50),
   Adresse_mail VARCHAR(50) NOT NULL,
   Mots_de_passe VARCHAR(50) NOT NULL,
   PRIMARY KEY(Utilisateur_id)
);