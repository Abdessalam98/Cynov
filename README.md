# Projet Cynov

> Projet permettant de mettre en pratique ses connainssances en C#

![screen projet](pics/desc.png)

## Objectif

Utiliser les notions vues en cours, à savoir : les fonctions, les collections, streams,...

## Description du projet

Lorem ipsum

## Organisation du projet

Le projet se présente comme suit :

```
├─ Cynov
|  ├─ Auditorium.cs
|  ├─ FileManager.cs
|  ├─ Film.cs
|  ├─ FilmType.cs
|  ├─ Main.cs
|  ├─ Order.cs
|  ├─ Program.cs
|  ├─ Showtime.cs
|  ├─ User.cs
|  ├─ Utils.cs
|  └─ Validator.cs
└─ Cynov.sln
```

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

**Méthodes**

- toString() <sup><code>-> string</code></sup>
  > <em>Heading and its markup split by newlines.</em>

### Class [`FileManager`](Cynov/FileManager.cs)

Propriétés

- \_fileManager <sup><code>FileManager</code></sup>
  > <em>Type FileManager</em>
- \_fileName <sup><code>string</code></sup>
  > <em>Nom du fichier sur lequel sera écrit le contenu</em>
- \_streamWriter <sup><code>StreamWriter</code></sup>
  > <em>StreamWriter pour écrire du contenu</em>

Méthodes

### Class [`Film`](Cynov/Film.cs)

Propriétés

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

Méthodes

### Class [`FilmType`](Cynov/FilmType.cs)

Propriétés
Méthodes

### Class [`Main`](Cynov/Main.cs)

Propriétés
Méthodes

### Class [`Order`](Cynov/Order.cs)

Propriétés

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

Méthodes

### Class [`Program`](Cynov/Program.cs)

Propriétés
Méthodes

### Class [`Showtime`](Cynov/Showtime.cs)

Propriétés

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

Méthodes

### Class [`User`](Cynov/User.cs)

Propriétés

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

Méthodes

### Class [`Utils`](Cynov/Utils.cs)

Propriétés
Méthodes

### Class [`Validator`](Cynov/Validator.cs)

Propriétés
Méthodes

## Parcours utilisateur / Scénario d'usage

## Execution du programme

Ce projet a été réalisé sur Visual Studio sous Windows 10

### Windows

### Linux

Si vous êtes sous Linux vérifiez que vous avez ces paquets installés

- dotnet-host
- dotnet-runtime-2.1
- dotnet-sdk-2.1

Ensuite deplacez vous dans le dossier contenant le projet et lancez la commande :

    dotnet run

## Améliorations

lorem ipsum

## Auteur

[Abdessalam BENHARIRA](https://github.com/Abdessalam98)
