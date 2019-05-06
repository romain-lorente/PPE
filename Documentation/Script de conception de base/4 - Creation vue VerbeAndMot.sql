CREATE VIEW VerbeAndMot AS
	SELECT 
		Mot1.id as idMot   , Mot1.texte as texte   , Mot1.genre as genre   , Mot1.nombre as nombre   ,
		Mot2.id as idMot_1S, Mot2.texte as texte_1S, Mot2.genre as genre_1S, Mot2.nombre as nombre_1S,
		Mot3.id as idMot_2S, Mot3.texte as texte_2S, Mot3.genre as genre_2S, Mot3.nombre as nombre_2S,
		Mot4.id as idMot_3S, Mot4.texte as texte_3S, Mot4.genre as genre_3S, Mot4.nombre as nombre_3S,
		Mot5.id as idMot_1P, Mot5.texte as texte_1P, Mot5.genre as genre_1P, Mot5.nombre as nombre_1P,
		Mot6.id as idMot_2P, Mot6.texte as texte_2P, Mot6.genre as genre_2P, Mot6.nombre as nombre_2P,
		Mot7.id as idMot_3P, Mot7.texte as texte_3P, Mot7.genre as genre_3P, Mot7.nombre as nombre_3P,
		fonction
	FROM verbe
	INNER JOIN Mot AS Mot1 ON Mot1.id = verbe.idMot
	INNER JOIN Mot AS Mot2 ON Mot2.id = verbe.idMot_1S
	INNER JOIN Mot AS Mot3 ON Mot3.id = verbe.idMot_2S
	INNER JOIN Mot AS Mot4 ON Mot4.id = verbe.idMot_3S
	INNER JOIN Mot AS Mot5 ON Mot5.id = verbe.idMot_1P
	INNER JOIN Mot AS Mot6 ON Mot6.id = verbe.idMot_2P
	INNER JOIN Mot AS Mot7 ON Mot7.id = verbe.idMot_3P;