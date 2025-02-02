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
  - Ptérosaures.
- **Score** : Augmente avec le temps. Plus tu cours, plus ton score grimpe !
- **Game Over** : Le jeu se termine si le dinosaure entre en collision avec un obstacle.

---

## 📂 Structure du projet

### **1. Scènes**
- **Menu** : Écran principal avec le bouton "Play".
- **SampleScene** : Scène principale du jeu

### **2. Assets**
- **Sprites** :
  - Dinosaure rose (course et saut).
  - Obstacles (cactus et ptérodactyles).
  - Sol gris et arrière plan rose.
- **UI** :
  - Polices élégantes pour afficher le score.
  - Boutons personnalisés pour le menu.

- **Scripts** :
  - `GameManager.cs` : Gestion globale (score, transitions de scènes, gameover, retry...).
  - `Player.cs` : Contrôle du dinosaure (mouvement, saut).
  - `Obstacle.cs` : Vitesse, défilement et destruction des obstacles.
  - `AnimatedSprite.cs` : Animation du joueur, des obstacles et du sol.
  - `Spawner.cs` : Génération aléatoire des obstacles.
  - `Ground.cs` : Boucle infini du défilement du sol.
  - `MainMenu.cs` : Changement de scène, intéraction avec les boutons du menu.


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
5. Relancer une partie depuis l'écran.

---

## 🤝 Crédits
- **Développeur** : Maxime Isidore, Noémie Dublanc.
- **Plateforme** : Unity 2023.x.
- **Inspiration** : Jeu Chrome Dino.
- **Tuto** : https://www.youtube.com/watch?v=UPvW8kYqxZk par Zigurous


