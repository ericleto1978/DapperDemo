# DapperDemo
Contenu:
* Effectue une requête SQL plusieurs à plusieurs

Pour utiliser:
* modifier le appsettings.json pour votre serveur BD et votre instance BD
* Créer les tables requises (Entreprise, Participant, Relation-Entreprise-Participant)

À améliorer: 
* La liste de participants est actuellement publique (nécessaire pour construire le résultat dans l'infrastructure)
* Puisque l'aggrégat hérite de EntiteBase, dans le retour au niveau de l'API, le Id est à la fin de la réponse (le réflexe naturel est de l'avoir au début)
