CREATE VIEW NomAndMot AS
	SELECT 
		Mot.id as idMot   , Mot.texte as texte   , Mot.genre as genre   , Mot.nombre as nombre   ,
		nature
	FROM Nom
	INNER JOIN Mot ON Mot.id = Nom.idMot;