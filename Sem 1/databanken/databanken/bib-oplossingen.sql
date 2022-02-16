/*
In dit bestand vind je de oplossingen van 'bib-opgaven.pdf'.

BELANGRIJK:
***********
Het is de bedoeling dat je deze oplossingen ENKEL gebruikt
om je EIGEN oplossingen te CONTROLEREN.
Probeer de oefeningen altijd eerst ZELF op te lossen
én UIT TE VOEREN op MySQL Workbench.
Pas DAARNA vergelijk je je SQL-instructie en resultaat
met de voorbeeld-oplossing in dit document.
Als je de oplossingen in dit document gewoon BEKIJKT,
dan leer je NIET ZELF SQL-instructies schrijven.

Verder:
Aarzel niet om fouten in dit document te melden
of om alternatieve oplossingen door te geven.
Je medestudenten en toekomstige studenten zullen je dankbaar zijn.
*/

-- SELECT

-- OEF 1
SELECT * FROM boeken;
-- OEF 2
SELECT titel, publ_jaar FROM boeken;
-- OEF 3
SELECT DISTINCT plaats FROM klant;
-- OEF 4
SELECT * FROM auteur ORDER BY naam;
-- OEF 5
SELECT * FROM boeken ORDER BY publ_jaar,titel;
-- OEF 6
SELECT * FROM uitleen ORDER BY datum DESC, uitlnr ASC;
-- OEF 7
SELECT * FROM boeken ORDER BY id LIMIT 5;
-- OEF 8
SELECT * FROM boeken ORDER BY id LIMIT 5 OFFSET 10;
SELECT * FROM boeken ORDER BY id LIMIT 10,5;
-- OEF 8b
SELECT * FROM boeken ORDER BY id LIMIT 10,9999999;
-- oplossing voor 8b is niet echt een mooie oplossing, maar eerder een 'hack'
-- OEF 9
SELECT * FROM boeken ORDER BY publ_jaar DESC LIMIT 4;
-- OEF 10
SELECT * FROM klant WHERE plaats = 'Brugge' ORDER BY klantnaam;
-- OEF 11
SELECT * FROM boeken WHERE cat_id = 2 AND publ_jaar <> 1993 ORDER BY publ_jaar DESC;
-- OEF 12
SELECT * FROM boeken WHERE publ_jaar BETWEEN 1970 AND 1999 ORDER BY publ_jaar;
-- OEF 13
SELECT * FROM boeken WHERE publ_jaar IN (1962,1993,1983,1999) ORDER BY publ_jaar;
-- OEF 14
SELECT * FROM klant WHERE klantnaam LIKE 'v%' ORDER BY klantnaam;
-- OEF 15
SELECT * FROM klant WHERE klantnaam LIKE '%v%' ORDER BY klantnaam;
-- OEF 16
SELECT * FROM boeken WHERE publ_jaar IS NULL;
-- OEF 17
SELECT * FROM boeken WHERE publ_jaar IS NOT NULL;
-- OEF 18
SELECT * FROM uitleen WHERE datum > '2013-05-03' ORDER BY datum;
-- OEF 19
SELECT * FROM boeken WHERE publ_jaar % 2 = 0;
-- '% 2' (of modulo 2) geeft de rest bij deling door 2 
SELECT * FROM boeken WHERE MOD(publ_jaar,2)=0;
-- OEF 20
SELECT * FROM uitleen WHERE YEAR(datum) = 2013;
-- OEF 21
SELECT * FROM uitleen WHERE YEAR(datum) = YEAR(NOW());
-- OEF 22
SELECT *,YEAR(NOW()) - YEAR(datum) AS 'Aantal jaar geleden' FROM uitleen;
-- OEF 22b: reken pas een volledig jaar na 365,25 dagen
SELECT *,ROUND(DATEDIFF(NOW(),datum)/365.25) AS 'Aantal volledige jaren geleden' FROM uitleen; 
-- OEF 23
SELECT * FROM klant ORDER BY REPLACE(klantnaam,' ','');
-- OEF 24
SELECT SUBSTRING_INDEX(titel,' ',1),titel FROM boeken;
SELECT SUBSTRING(titel,1,LOCATE(' ',titel)),titel FROM boeken;
SELECT LOCATE(' ',titel),titel FROM boeken;
-- OEF 25
SELECT UPPER(TRIM(titel)) FROM boeken ORDER BY REPLACE(titel,' ','');
-- OEF 26
SELECT uitgever, SOUNDEX(uitgever) AS 'Soundex' FROM uitgever ORDER BY uitgever;
-- OEF 27
SELECT * FROM uitgever WHERE SOUNDEX('QUARYTOO') = SOUNDEX(uitgever);
-- OEF 28
SELECT curdate(),DATE_FORMAT(curdate(),'%d-%m-%Y') as 'Nice date' ;
-- OEF 29
SELECT uitlnr,datum,DATE_FORMAT(datum,'%d-%m-%Y') as 'geformatteerde datum.' FROM uitleen;

-- INSERT

-- OEF 30
INSERT INTO uitgever VALUES (20,'Mc Graw Hill'), (21,'Van Duuren Media');
-- OEF 31
INSERT INTO uitleen VALUES (50,2,'2017-08-20',1);
-- OEF 32
INSERT INTO klant (klant_id,klantnaam) VALUES (30,'De lange');
INSERT INTO klant VALUES (30,'De lange',NULL);
-- OEF 33
INSERT INTO auteur VALUES (30,'Dusan Petkovic');
INSERT INTO boeken (id,auteur_id,titel,cat_id,uitg_id) VALUES (80,30,'SQL A Beginners Guide',3,20);

-- UPDATE

-- OEF 34
UPDATE klant SET plaats = 'De Haan' WHERE klant_id = 10;
-- OEF 35
UPDATE uitleen SET datum=ADDDATE(datum,5) WHERE klant_id = 3;
-- OEF 36
UPDATE klant SET klantnaam = 'Arnoldus',plaats = 'Nieuwpoort' WHERE klant_id = 10;
-- OEF 37
UPDATE boeken SET publ_jaar = publ_jaar + 1 WHERE cat_id = 2;
-- OEF 37 met subquery
UPDATE boeken SET publ_jaar = publ_jaar + 1 WHERE cat_id = (SELECT cat_id FROM categorie WHERE categorie = 'fictie');

-- DELETE

-- OEF 38
DELETE FROM boeken WHERE id = 10;
-- OEF 39
DELETE FROM auteur WHERE id NOT IN (SELECT DISTINCT auteur_id FROM boeken);
-- OEF 40
DELETE FROM auteur WHERE id IN (SELECT DISTINCT auteur_id FROM boeken);
-- OEF 41
TRUNCATE uitleen;

-- AGGREGAATFUNCTIES

-- OEF 42
SELECT COUNT(*) FROM boeken;
-- OEF 43
SELECT
    COUNT(id) AS 'aantal boeken',
    MIN(publ_jaar) AS 'Eerste Uitgave',
    MAX(publ_jaar) AS 'Laatste Uitgave',
    MAX(publ_jaar) - MIN(publ_jaar) AS 'Verschil tussen beide'
FROM boeken;
-- OEF 44
SELECT publ_jaar, COUNT(*) FROM boeken GROUP BY publ_jaar;
-- OEF 45
SELECT COUNT(DISTINCT LEFT(klantnaam, 1)) AS 'Verschillende eerste letters' FROM klant;
-- OEF 46
SELECT AVG(publ_jaar) FROM boeken WHERE cat_id = 3;

-- JOIN

-- OEF 47
SELECT * FROM boeken b JOIN uitgever u ON b.uitg_id=u.uitg_id ORDER BY u.uitgever;
SELECT * FROM boeken JOIN uitgever USING(uitg_id) ORDER BY uitgever;
-- OEF 48
SELECT b.titel,b.publ_jaar
FROM boeken b JOIN uitgever u ON b.uitg_id=u.uitg_id
WHERE u.uitgever='De Bezige Bij' AND b.publ_jaar>1980
ORDER BY b.titel;
SELECT titel,publ_jaar
FROM boeken JOIN uitgever USING(uitg_id)
WHERE uitgever = 'De Bezige Bij' AND publ_jaar > 1980
ORDER BY titel;
-- OEF 49
SELECT b.titel,a.naam AS auteur
FROM boeken b
   JOIN categorie c ON b.cat_id=c.cat_id
   JOIN auteur a ON b.auteur_id = a.id
WHERE c.categorie = 'wetenschappelijk' 
ORDER BY b.titel;
-- OEF 50
SELECT b.titel,b.publ_jaar AS 'jaar van uitgifte',u.uitgever,a.naam AS auteur,c.categorie
FROM boeken b
   JOIN uitgever u ON b.uitg_id=u.uitg_id
   JOIN auteur a ON b.auteur_id = a.id
   JOIN categorie c ON b.cat_id=c.cat_id
ORDER BY b.titel;
-- OEF 51
SELECT COUNT(*) AS 'Aantal boeken van De Bezige Bij'
FROM boeken
   JOIN uitgever USING(uitg_id)
WHERE uitgever = 'De Bezige Bij';
-- OEF 52
SELECT b.titel,u.datum
FROM boeken b
   JOIN uitleen u ON b.id = u.boek_id
WHERE YEAR(u.datum) = 2013 AND (b.cat_id=2 OR b.cat_id=3);
-- OEF 53
SELECT k.*,u.datum 'Uitleendatum',b.titel 'Boektitel'
FROM uitleen u
   JOIN klant k USING(klant_id)
   JOIN boeken b ON b.id = u.boek_id
ORDER BY klant_id;
-- OEF 54
SELECT k.*
FROM boeken b
   JOIN uitleen u ON b.id = u.boek_id
   JOIN klant k USING(klant_id)
   JOIN auteur a ON b.auteur_id = a.id
WHERE a.naam = 'Breemeersch';
-- OEF 55
SELECT a.klant_id, a.klantnaam, a.plaats
FROM klant a JOIN klant b
   ON a.klantnaam = b.klantnaam
WHERE a.klant_id <> b.klant_id;
SELECT a.klant_id, a.klantnaam, a.plaats
FROM klant a, klant b
WHERE a.klantnaam = b.klantnaam AND a.klant_id <> b.klant_id;
-- OEF 56
SELECT * FROM klant k
   LEFT OUTER JOIN uitleen u ON k.klant_id=u.klant_id
ORDER BY k.klant_id;
-- OEF 57
SELECT b.id,b.titel,u.datum
FROM boeken b
   LEFT OUTER JOIN uitleen u ON b.id=u.boek_id
ORDER BY b.id;
-- OEF 58
SELECT u.uitgever,b.titel,c.categorie
FROM uitgever u
   LEFT JOIN boeken b ON u.uitg_id=b.uitg_id
   LEFT JOIN categorie c ON c.cat_id=b.cat_id
ORDER BY u.uitg_id;

-- Dankwoord:
-- Student Burak Balci (2020-2021) leverde een lijst
-- met een oplossing voor elke oefening. Deze lijst
-- was de basis voor de eerste versie van dit document.
