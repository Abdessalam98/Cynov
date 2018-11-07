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
  > <em>Heading and its markup split by newlines.</em>
- Name <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Capacity <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- CurrentCapacity <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>

**Méthodes**

- toString() <sup><code>-> string</code></sup>
  > <em>Heading and its markup split by newlines.</em>

### Class [`FileManager`](Cynov/FileManager.cs)

Propriétés

- \_fileManager <sup><code>FileManager</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- \_fileName <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- \_streamWriter <sup><code>StreamWriter</code></sup>
  > <em>Heading and its markup split by newlines.</em>

Méthodes

### Class [`Film`](Cynov/Film.cs)

Propriétés

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Name <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Director <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Producer <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Gender <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- ReleaseDate <sup><code>DateTime</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Type <sup><code>FilmType</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Showtimes <sup><code>List\<Showtime\>()</code></sup>
  > <em>Heading and its markup split by newlines.</em>

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
  > <em>Heading and its markup split by newlines.</em>
- Company <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Price <sup><code>double</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- OrderId <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- User <sup><code>User</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Showtime <sup><code>Showtime</code></sup>
  > <em>Heading and its markup split by newlines.</em>

Méthodes

### Class [`Program`](Cynov/Program.cs)

Propriétés
Méthodes

### Class [`Showtime`](Cynov/Showtime.cs)

Propriétés

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Auditorium <sup><code>Auditorium</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Start <sup><code>DateTime</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Finish <sup><code>DateTime</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- ThreeDimensional <sup><code>bool</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- OriginalVersion <sup><code>bool</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Users <sup><code>List\<Users\>()</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Film <sup><code>Film</code></sup>
  > <em>Heading and its markup split by newlines.</em>

Méthodes

### Class [`User`](Cynov/User.cs)

Propriétés

- Id <sup><code>int</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Username <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Email <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Password <sup><code>string</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- IsAdmin <sup><code>bool</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- IsActive <sup><code>bool</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- LastUpdateTime <sup><code>DateTime</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Showtimes <sup><code>List\<Showtime\>()</code></sup>
  > <em>Heading and its markup split by newlines.</em>
- Orders <sup><code>List\<Order\>()</code></sup>
  > <em>Heading and its markup split by newlines.</em>

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
