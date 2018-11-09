# Projet Cynov

> Projet permettant de mettre en pratique ses connainssances en C#

## Objectif

Utiliser les notions vues en cours, à savoir : les fonctions, les collections, streams, programmation objet...

## Description du projet

Réaliser une application pour le cinéma Cynov

## Compétences évaluées

- Livrer un code qui compile
- Bonne utilisation des Design Patterns
- Savoir modéliser une structure objet via une demande client
- Utilisation de l’orienté objet
- Savoir stocker des données dans une base de données
- Bonne utilisation de LINQ
- Gérer les comportements imprévus via des exceptions
- Gérer des chemins de code différents selon le niveau de droits du visiteur
- Savoir verrouiller son code pour réduire les effets de bord futurs
- Qualité de code et Conventions de nommage

## Organisation du projet

Le projet se présente comme suit :

## Classes et méthodes

### Class [`Auditorium`](Cynov/Auditorium.cs)

**Propriétés**

- Id <sup><code>int</code></sup>
  > <em>Identifiant de Auditorium nécessaire aussi à la BDD</em>
- Name <sup><code>string</code></sup>
  > <em>Nom de l'Auditorium</em>
- Capacity <sup><code>string</code></sup>
  > <em>Capacité totale de l'Auditorium</em>
- CurrentCapacity <sup><code>string</code></sup>
  > <em>Capacité actuelle de l'auditorium</em>

### Class [`FileManager`](Cynov/FileManager.cs)

**Propriétés**

- \_fileManager <sup><code>FileManager</code></sup>
  > <em>Type FileManager</em>
- \_fileName <sup><code>string</code></sup>
  > <em>Nom du fichier sur lequel sera écrit le contenu</em>
- \_streamWriter <sup><code>StreamWriter</code></sup>
  > <em>StreamWriter pour écrire du contenu</em>

**Méthodes**

- WriteToFile(string fileName, string content) <sup><code>-> void</code></sup>

### Class [`Film`](Cynov/Film.cs)

**Propriétés**

- Id <sup><code>int</code></sup>
  > <em>Identifiant de Film nécessaire aussi à la BDD</em>
- Name <sup><code>string</code></sup>
  > <em>Nom du film</em>
- Director <sup><code>string</code></sup>
  > <em>Directeur du film</em>
- Producer <sup><code>string</code></sup>
  > <em>Producteur du film </em>
- Gender <sup><code>string</code></sup>
  > <em>Genre du film</em>
- ReleaseDate <sup><code>DateTime</code></sup>
  > <em>Date de sortie</em>
- Type <sup><code>FilmType</code></sup>
  > <em>Type du film (enum de 3 valeurs)</em>
- Showtimes <sup><code>List\<Showtime\>()</code></sup>
  > <em>Liste des séances associées </em>

### Class [`FilmType`](Cynov/FilmType.cs)

### Class [`Main`](Cynov/Main.cs)

**Méthodes**

- Start() <sup><code>-> void</code></sup>

  > <em>Lance le programme</em>

- Menu() <sup><code>-> int</code></sup>

  > <em>Affiche le menu récupére le choix de l'utlisateur</em>

- SignUp() <sup><code>-> void</code></sup>

  > <em>Inscrit un utilisateur</em>

- SignIn() <sup><code>-> void</code></sup>

  > <em>Connecte l'utilisateur</em>

- Search() <sup><code>-> void</code></sup>

  > <em>Effectue une recherche </em>

- Exit() <sup><code>-> void</code></sup>

  > <em>Quitte la console</em>

- GetCreditentials(User u) <sup><code>-> void</code></sup>

  > <em>Récupère les identifiants de l'utilisateur</em>

- AddFilms() <sup><code>-> void</code></sup>

  > <em>Ajoute des films</em>

- AddShowTimes() <sup><code>-> void</code></sup>

  > <em>Ajoute des séances</em>

- RegisterToShowTime() <sup><code>-> void</code></sup>

  > <em>Enregistre une séance pour un utilisateur</em>

- ViewUserHistory() <sup><code>-> void</code></sup>

  > <em>Voir les commandes de l'utilisateur</em>

- ListFilms() <sup><code>-> void</code></sup>

  > <em>Liste les films</em>

- ListAuditoriums() <sup><code>-> void</code></sup>

  > <em>Liste les salles</em>

- ListShowTimes(IEnumerable<Showtime> showtimes = null) <sup><code>-> void</code></sup>

  > <em>Liste les séances</em>

- CreateAuditoriums() <sup><code>-> void</code></sup>

  > <em>Crée des salles</em>

- AddOrder(Showtime showTime) <sup><code>-> Order</code></sup>

  > <em>Affecte une commande</em>

static void PrintTicket(User u, Order o)

- PrintTicket(User u, Order o) <sup><code>-> void</code></sup>

  > <em>Imprime le bon de commande</em>

- IsAlreadyRegistered(int inputChoice, User user) <sup><code>-> bool</code></sup>

  > <em>Vérifie si l'utilisateur a déjà pris une séance</em>

### Class [`Order`](Cynov/Order.cs)

**Propriétés**

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- PrintDate <sup><code>DateTime</code></sup>
  > <em>Date d'impression</em>
- Company <sup><code>string</code></sup>
  > <em>Le ciméma en question d'où provient la commande</em>
- Price <sup><code>double</code></sup>
  > <em>Prix de la commande</em>
- OrderId <sup><code>string</code></sup>
  > <em>GUID de la commande</em>
- User <sup><code>User</code></sup>
  > <em>L'utilisateur associé</em>
- Showtime <sup><code>Showtime</code></sup>
  > <em>La séance associée</em>

### Class [`Program`](Cynov/Program.cs)

### Class [`Showtime`](Cynov/Showtime.cs)

**Propriétés**

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Auditorium <sup><code>Auditorium</code></sup>
  > <em>La salle associée</em>
- Start <sup><code>DateTime</code></sup>
  > <em>Date de début</em>
- Finish <sup><code>DateTime</code></sup>
  > <em>Date de fin</em>
- ThreeDimensional <sup><code>bool</code></sup>
  > <em>En 3D</em>
- OriginalVersion <sup><code>bool</code></sup>
  > <em>En VO</em>
- Users <sup><code>List\<Users\>()</code></sup>
  > <em>Liste d'utilisateurs associés</em>
- Film <sup><code>Film</code></sup>
  > <em>Film associé</em>

### Class [`User`](Cynov/User.cs)

**Propriétés**

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Username <sup><code>string</code></sup>
  > <em>Nom d'utilisateur</em>
- Email <sup><code>string</code></sup>
  > <em>Email de l'utilisateur</em>
- Password <sup><code>string</code></sup>
  > <em>Mot de passe de l'utilisateur</em>
- IsAdmin <sup><code>bool</code></sup>
  > <em>Booléen si administrateur </em>
- IsActive <sup><code>bool</code></sup>
  > <em>Booléen si le compte est actif</em>
- LastUpdateTime <sup><code>DateTime</code></sup>
  > <em>Dernière date de mise à jour</em>
- Showtimes <sup><code>List\<Showtime\>()</code></sup>
  > <em>Liste des séances associées</em>
- Orders <sup><code>List\<Order\>()</code></sup>
  > <em>Liste des commandes associées</em>

**Méthodes**

- toString() <sup><code>-> string</code></sup>

### Class [`Utils`](Cynov/Utils.cs)

### Class [`Validator`](Cynov/Validator.cs)

## Parcours utilisateur / Scénario d'usage

On part du principe qu'on autorise que les insriptions d'utilisateurs ordinaires. Pour rajouter un administrateur on doit set le champ `IsAdmin` (par défaut false) à true lors de la création. Un administrateur est déjà crée `admin@cynov.com/1234`. Ce dernier peut rajouter des films et des séances. Un utilisateur ordinaire est aussi crée `a.benharira@dotwiz.fr/1234`. Celui ci pourra s'incrire à une séance, effectuer une recherche et voir ses séances achetées. Lors de son achat un fichier est créé sur son bureau et ce sur le format suivant `20181109-070311-cc93e817fa-abdessalam.txt`

## Execution du programme

Ce projet a été réalisé sur Visual Studio sous Windows 10

### Windows

Ouvrir le projet avec Visual Studio

### Linux

Si vous êtes sous Linux vérifiez que vous avez ces paquets installés

- dotnet-host
- dotnet-runtime-2.1
- dotnet-sdk-2.1

Ensuite deplacez vous dans le dossier contenant le projet et lancez la commande :

    dotnet run

## Auteur

[Abdessalam BENHARIRA](https://github.com/Abdessalam98)
