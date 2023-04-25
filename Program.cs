using System.Xml;
using ExerciceXmlReader;

var reader = XmlReader.Create("fichier.xml");
var personne = new Personne();

///SE PLACE SUR LA BALISE INITIALE
reader.MoveToContent();
///AVANCE SUR L ELEMENT PERSONNE
reader.ReadStartElement("Personne");
///AVANCE SUR LA BALISE D'OUVERTURE NOM
reader.ReadStartElement("Nom");
///AVANCE EN LISANT SOUS FORME DE CHAINE
personne.Nom = reader.ReadContentAsString();
///AVANCE SUR LA BALISE DE FIN
reader.ReadEndElement();

///RECOMMENCE AVEC LA BALISE PRENOM
reader.ReadStartElement("Prenom");
personne.Prenom = reader.ReadContentAsString();
reader.ReadEndElement();

///RECOMMENCE AVEC LA BALISE DATEDENAISSANCE
reader.ReadStartElement("DateDeNaissance");
personne.DateDeNaissance = reader.ReadContentAsDateTime();
reader.ReadEndElement();

///RECOMMENCE AVEC LA TAILLE
reader.ReadStartElement("Taille");
personne.Taille = reader.ReadContentAsInt();
reader.ReadEndElement();

///LIT LA BALISE DE FERMETURE DU DOCUMENT
reader.ReadEndElement();

System.Console.WriteLine($"{personne.Prenom} {personne.Nom} né le {personne.DateDeNaissance:dd/MM/yyyy} mesure {personne.Taille}cm");


