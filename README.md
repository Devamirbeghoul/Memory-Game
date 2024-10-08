﻿# Memory Game

## Description
This is a simple **Memory Game** implemented using **C#** and **Windows Forms**. The game challenges players to match pairs of cards. Once all pairs are found, the game is completed. It's a fun and interactive way to improve memory skills!

## Features
- Interactive user interface using Windows Forms
- Grid-based card layout
- Random card placement at the start of each game
- Match pairs of cards by flipping them
- Score tracking based on moves made
- Replay option after game completion

## Technologies
- **C#** (.NET Framework)
- **Windows Forms** for the graphical user interface

## How to Play
1. Launch the game.
2. A grid of cards will be displayed face down.
3. Click on a card to reveal it.
4. Click on a second card to try and find its match.
5. If the two cards match, they remain face up. If they don't, both cards will flip back face down.
6. Continue this process until all pairs are matched.

## Installation
1. Clone the repository or download the source code.
   ```bash
   git clone https://github.com/CidKagenou007/MemoryGame.git
   ```
2. Open the project in **Visual Studio**.
3. Build and run the project.

## Usage
- **Start Game**: Begin the game with a shuffled set of cards.
- **Reset Game**: Restart the game with a new shuffle.
- **Exit**: Close the game window.

## File Structure
```
MemoryGame/
│
├── Forms/
│   ├── MemeoryGameScreen.cs          # Main game form where the grid and logic are displayed
│   └── MemeoryGameScreen.Designer.cs # Auto-generated designer file for the form layout
│
├── Images/
│   └── pics/                         # Folder containing images used for the cards
│
├── Program.cs                        # Application entry point
├── MemoryGame.csproj                  # Project file for the C# application
└── README.md                         # This README file
```

## Future Enhancements
- Add difficulty levels (e.g., increasing grid size).
- Implement a timer to track how quickly players complete the game.
- Include sound effects and animations for card flips and matches.

---

## Credits
- **Developer:** [Amir Abdeldjalil]
- **GitHub:** [devamirbeghoul](https://github.com/devamirbeghoul)
- **Contact:** [zruchiha005@gmail.com](mailto:zruchiha005@gmail.com)
