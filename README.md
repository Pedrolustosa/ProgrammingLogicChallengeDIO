# 🛡️ Heroic Adventures - C# Console Applications

[![C#](https://img.shields.io/badge/C%23-.NET%208.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![ConsoleApp](https://img.shields.io/badge/Console%20App-Heroic%20Adventures-green.svg)](https://dotnet.microsoft.com/en-us/apps/aspnet/console)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This repository contains three C# console applications that simulate different aspects of a hero's journey through various challenges. Each project demonstrates fundamental programming concepts such as classes, functions, conditionals, loops, and decision structures. These applications were built using **.NET 8.0** to explore hero-based adventures.

## 📦 Projects

### 1️⃣ **Hero XP Level Classifier**

In this challenge, a hero's experience points (XP) determine their rank. Based on the amount of XP, the hero is classified into different levels ranging from **Ferro** to **Radiante**.

#### 📝 How It Works:

- The program asks for the hero's name and their total XP.
- Depending on the XP provided, the hero is ranked in one of the following categories:
  - **XP < 1,000**: Ferro
  - **1,001 <= XP <= 2,000**: Bronze
  - **2,001 <= XP <= 5,000**: Prata
  - **5,001 <= XP <= 7,000**: Ouro
  - **7,001 <= XP <= 8,000**: Platina
  - **8,001 <= XP <= 9,000**: Ascendente
  - **9,001 <= XP <= 10,000**: Imortal
  - **XP >= 10,001**: Radiante

#### 💻 Example:

```
Digite o nome do herói:
Arthur
Digite a quantidade de XP do herói:
5500
O Herói de nome Arthur está no nível de Ouro.
```

### 2️⃣ **Ranked Match Calculator**

In this challenge, the hero's win/loss record is used to calculate their performance rank in ranked matches. The program calculates the hero's net victories (wins - losses) and determines their performance level based on their total wins.

📝 How It Works:
The program asks for the total number of wins and losses.
Based on the total wins, the hero is ranked in one of the following levels:
Wins < 10: Ferro
11 <= Wins <= 20: Bronze
21 <= Wins <= 50: Prata
51 <= Wins <= 80: Ouro
81 <= Wins <= 90: Diamante
91 <= Wins <= 100: Lendário
Wins >= 101: Imortal

```
Digite a quantidade de vitórias:
45
Digite a quantidade de derrotas:
20
O Herói tem um saldo de 25 e está no nível de Prata.
```

### 3️⃣ **Hero Class with Attack Function**

In this challenge, a generic Hero class is created, allowing a hero to have properties like name, age, and type. The hero can then perform an attack, and the attack message varies based on the hero's type (e.g., Warrior, Mage, Monk, Ninja).

📝 How It Works:
The program creates a Hero object with the following properties:
Name
Age
Type: Either "mago", "guerreiro", "monge", or "ninja"
The Atacar method displays a different attack message depending on the hero's type:
mago: uses "magia"
guerreiro: uses "espada"
monge: uses "artes marciais"
ninja: uses "shuriken"

```
Digite o nome do herói:
Zane
Digite a idade do herói:
30
Digite o tipo do herói (mago, guerreiro, monge, ninja):
ninja
O ninja atacou usando shuriken.
```

⚙️ Tech Stack
Language: C# (.NET 8.0)
Platform: Console Application
Tools: Visual Studio, .NET SDK

Getting Started
Clone the repository:

bash
Copiar código
```
git clone https://github.com/your-username/heroic-adventures.git
```
```
cd heroic-adventures
```
Ensure you have .NET 8.0 installed: Download the .NET SDK from the official Microsoft website.

Run the applications: Each project is a simple console app. You can run them using the following command:

bash
Copiar código
```
dotnet run
```
Follow the prompts to interact with each application.

📜 License
This repository is licensed under the MIT License. See the LICENSE file for details.
