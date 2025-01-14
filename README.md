# Dino-Pink 🌸
**Un "One Button Game" inspiré du jeu Chrome Dino, en version rose !**

---

## 🚀 Introduction

Dino-Pink est un jeu d'arcade 2D basé sur le célèbre jeu Chrome Dino. Le joueur contrôle un dinosaure rose qui court à l'infini et doit éviter des obstacles en sautant. Simple, rapide et addictif !

---

## 🕹️ Règles du jeu

- **Objectif** : Parcourir la plus grande distance possible sans heurter d'obstacles.
- **Contrôle** : Une seule touche pour sauter (par défaut : la barre d'espace).
- **Obstacles** : 
  - Cactus (hauteur variable).
  - Ptérosaures (à différentes altitudes).
- **Score** : Augmente avec le temps. Plus tu cours, plus ton score grimpe !
- **Game Over** : Le jeu se termine si le dinosaure entre en collision avec un obstacle.

---

## 📂 Structure du projet

### **1. Scènes**
- **MainMenu** : Écran principal avec le bouton "Start Game".
- **GameScene** : Scène principale du jeu.
- **GameOverScene** : Affiche le score final avec un bouton pour recommencer.

### **2. Assets**
- **Sprites** :
  - Dinosaure rose (course et saut).
  - Obstacles (cactus et ptérodactyles).
  - Sol gris et arrière plan rose.
- **UI** :
  - Polices élégantes pour afficher le score.
  - Boutons personnalisés pour le menu.

- **Scripts** :
  - `GameManager.cs` : Gestion globale (score, transitions de scènes).
  - `Player.cs` : Contrôle du dinosaure (mouvement, saut).
  - `ObstacleSpawner.cs` : Génération aléatoire des obstacles.
  - `ScrollingBackground.cs` : Défilement infini de l'arrière-plan.

---

## 📜 Scripts principaux

### **1. GameManager.cs**
Gère les règles principales :
- Singleton pour un accès global.
- Variables globales (score, état du jeu).
- Méthodes pour :
  - Ajouter des points.
  - Gérer le Game Over.
  - Charger/recharger les scènes.

### **2. PlayerController.cs**
Contrôle le mouvement et les animations du dinosaure :
- Gestion du saut via Rigidbody2D.
- Détection des collisions avec les obstacles.

### **3. ObstacleSpawner.cs**
- Génère des obstacles à intervalles réguliers.
- Ajuste la difficulté avec le temps (plus d’obstacles et vitesse accrue).

### **4. ScrollingBackground.cs**
Crée l’effet de défilement infini de l’arrière-plan et du sol.

---

## 🎮 Configuration du projet

### **1. Paramètres de physique**
- Désactiver la gravité par défaut (sauf pour les objets nécessaires).
- Ajouter des colliders 2D pour les interactions.

### **2. Couleur et style**
- Palette principale : nuances de rose.
- Fond : rose clair pour une ambiance douce.
- Obstacles : rose foncé pour le contraste.

---

## 🔧 Améliorations futures

- **Cycle jour/nuit** : Alterner entre un ciel rose et violet.
- **Power-ups** : Ajouter des bonus comme l'invincibilité temporaire.
- **Personnalisation** : Choisir d'autres couleurs.
- **Classement** : Intégrer un tableau des scores.

---

## 🎨 Ressources utilisées

- **Sprites** : Téléchargés depuis dino chrome et modifier par la suite en rose.

---

## 📋 Instructions pour jouer

1. Lancer le jeu depuis Unity ou l'exécutable généré.
2. Appuyer sur "Start" pour commencer.
3. Appuyer sur la barre d'espace pour sauter par-dessus les obstacles.
4. Jouer jusqu'à ce que vous heurtiez un obstacle.
5. Relancer une partie depuis l'écran Game Over.

---

## 🤝 Crédits
- **Développeur** : Maxime Isidore, Noémie Dublanc.
- **Plateforme** : Unity 2023.x.
- **Inspiration** : Jeu Chrome Dino.
