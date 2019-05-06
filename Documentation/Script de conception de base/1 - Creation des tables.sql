CREATE TABLE Utilisateur(
	username VARCHAR(32)  NOT NULL,
	password VARCHAR(64)  NOT NULL,
	nom      VARCHAR(32)  NOT NULL,
	prenom   VARCHAR(32)  NOT NULL,
	bstScore INT          NOT NULL DEFAULT 0,
	isAdmin  INT          NOT NULL DEFAULT 0,

	CONSTRAINT PK_Utilisateur    PRIMARY KEY(username)
);

CREATE TABLE Mot(
	id       INT          NOT NULL IDENTITY(1, 1),
	texte    VARCHAR(32)  NOT NULL,
	genre    VARCHAR(32)  NOT NULL,
	nombre   VARCHAR(32)  NOT NULL,
	type     VARCHAR(32)  NOT NULL,

	CONSTRAINT PK_Mot PRIMARY KEY(id)
);

CREATE TABLE Verbe(
	idMot    INT          NOT NULL,
	idMot_1S INT          NOT NULL,
	idMot_2S INT          NOT NULL,
	idMot_3S INT          NOT NULL,
	idMot_1P INT          NOT NULL,
	idMot_2P INT          NOT NULL,
	idMot_3P INT          NOT NULL,
	fonction VARCHAR(32)  NOT NULL,

	CONSTRAINT PK_Verbe          PRIMARY KEY(idMot),

	CONSTRAINT FK_Verbe_idMot    FOREIGN KEY(idMot)    REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_1S FOREIGN KEY(idMot_1S) REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_2S FOREIGN KEY(idMot_2S) REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_3S FOREIGN KEY(idMot_3S) REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_1P FOREIGN KEY(idMot_1P) REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_2P FOREIGN KEY(idMot_2P) REFERENCES Mot(id),
	CONSTRAINT FK_Verbe_idMot_3P FOREIGN KEY(idMot_3P) REFERENCES Mot(id)
);

CREATE TABLE Nom(
	idMot    INT          NOT NULL,
	nature   VARCHAR(32)  NOT NULL,

	CONSTRAINT PK_Nom            PRIMARY KEY(idMot),
	CONSTRAINT FK_Nom_idMot      FOREIGN KEY(idMot)    REFERENCES Mot(id)
);

CREATE TABLE Adjectif(
	idMot    INT          NOT NULL,
	fonction VARCHAR(32)  NOT NULL,

	CONSTRAINT PK_Adjectif       PRIMARY KEY(idMot),
	CONSTRAINT FK_Adjectif_idMot FOREIGN KEY(idMot)    REFERENCES Mot(id)
);

CREATE TABLE Phrase(
	id       INT          NOT NULL IDENTITY(1, 1),
	texte    VARCHAR(256) NOT NULL,

	CONSTRAINT PK_Phrase  PRIMARY KEY(id)
);

CREATE TABLE MotDansPhrase(
	id       INT          NOT NULL IDENTITY(1, 1),
	idMot    INT          NOT NULL,
	idPhrase INT          NOT NULL,
	position INT          NOT NULL,

	CONSTRAINT PK_MotDansPhrase  PRIMARY KEY(id),
	
	CONSTRAINT FK_MotDansPhrase_idMot    FOREIGN KEY(idMot)    REFERENCES Mot(id),
	CONSTRAINT FK_MotDansPhrase_idPhrase FOREIGN KEY(idPhrase) REFERENCES Phrase(id)
);