CREATE VIEW AdjectifAndMot AS
	SELECT 
		Mot.id as idMot   , Mot.texte as texte   , Mot.genre as genre   , Mot.nombre as nombre   ,
		fonction
	FROM Adjectif
	INNER JOIN Mot ON Mot.id = Adjectif.idMot;