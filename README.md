# 📈 Gestion de Portefeuilles Boursiers — C# .NET

Application console développée en **C# .NET** permettant de gérer un portefeuille d'actions boursières.

---

## 🚀 Fonctionnalités

- ✅ Ajouter plusieurs actions boursières (nom, prix d'achat, prix actuel, quantité)
- ✅ Calculer la **valeur actuelle** de chaque action
- ✅ Calculer le **gain ou la perte** par action
- ✅ Afficher la **valeur totale** du portefeuille
- ✅ Identifier les **actions en perte**
- ✅ Validation des saisies : si l'utilisateur entre une lettre à la place d'un nombre, le programme affiche un message d'erreur et **redemande la saisie** sans jamais crasher

---

## 🏗️ Structure du projet

```
GestionPortefeuilles/
├── GestionPortefeuilles/
│   └── Program.cs        # Code source principal
├── .gitignore            # Fichiers ignorés par Git
└── README.md             # Ce fichier
```

---

## ▶️ Lancer le projet

1. Ouvrir le projet dans **Visual Studio**
2. Appuyer sur `F5` ou cliquer sur **Démarrer**
3. Suivre les instructions dans la console

---

## 💻 Exemple d'exécution

```
Combien d'actions voulez-vous ajouter ? : 2

--- Action 1 ---
Nom de l'action : Apple
Prix d'achat : 150.5
Prix actuel : 180.0
Quantité : 10

--- Action 2 ---
Nom de l'action : Tesla
Prix d'achat : 300.0
Prix actuel : 250.0
Quantité : 5

===== RESULTATS =====

Action : Apple
Valeur actuelle : 1800 DH
Gain / Perte : 295 DH
---------------------------
Action : Tesla
Valeur actuelle : 1250 DH
Gain / Perte : -250 DH
⚠️  Action en perte
---------------------------

Valeur totale du portefeuille : 3050 DH
Actions en perte : Tesla
```

---

## 🛠️ Technologies utilisées

| Technologie | Version |
|---|---|
| Langage | C# |
| Framework | .NET 8 |
| IDE | Visual Studio 2022 |

---

## 👩‍💻 Auteur

**Wissal Badri** — TP C# .NET — Semestre 2 — 2026
