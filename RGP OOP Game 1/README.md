# RPG Battle Game

## Project Description
A turn-based RPG Battle Game built with C# and Windows Forms for ITS203 Object-Oriented Design and Programming. The player selects a hero class and battles through enemies to defeat the final boss Dragon.

## How to Run
1. Clone this repository
2. Open `RGP OOP Game 1.sln` in Microsoft Visual Studio 2022
3. Press F5 or click the green play button to run
4. Make sure .NET 8.0 is installed on your machine

## How to Play
- Click **NEW GAME** on the main menu
- Choose your character class: Warrior, Mage or Rogue
- In battle, click **ATTACK** for a normal attack
- Click **SPECIAL** to use your character's special ability
- Click **FLEE** to return to the main menu
- Defeat Goblin, Orc and Dragon to win!

## Character Classes
- **Warrior** - High HP (150), Shield Block special ability
- **Mage** - High Attack (25), Fireball special ability
- **Rogue** - Balanced stats, Sneak Attack special ability (40% chance of 3x damage)

## Enemies
- **Goblin** - Weak enemy, fast attacks
- **Orc** - Strong enemy, Berserk attack
- **Dragon** - Final boss, Fire Breath attack

## OOP Principles Demonstrated
- **Abstraction** - Character is an abstract base class
- **Inheritance** - Hero and Enemy extend Character; Warrior, Mage, Rogue extend Hero
- **Polymorphism** - Each class overrides SpecialAbility() differently
- **Encapsulation** - All stats are private with public properties
- **Exception Handling** - Try-catch blocks throughout BattleManager and all forms

## Project Structure
- `Character.cs` - Abstract base class
- `Hero.cs` - Abstract hero class extending Character
- `Enemy.cs` - Abstract enemy class extending Character
- `Warrior.cs`, `Mage.cs`, `Rogue.cs` - Hero subclasses
- `Goblin.cs`, `Orc.cs`, `Dragon.cs` - Enemy subclasses
- `BattleManager.cs` - Manages all battle logic
- `MainMenuForm.cs` - Main menu screen
- `CharacterSelectForm.cs` - Character selection screen
- `BattleForm.cs` - Battle screen with HP bars
- `GameOverForm.cs` - Win/loss screen

## References and Tools Used
- Microsoft Visual Studio 2022 Community Edition
- .NET 8.0 Windows Desktop Development
- Microsoft Learn - C# Documentation: https://learn.microsoft.com/en-us/dotnet/csharp/
- Microsoft Learn - Windows Forms: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
- GitHub Skills: https://skills.github.com
- Claude AI (Anthropic) - used for debugging assistance and learning support

## Developer
- **Name:** Nischal Sapkota
- **Unit:** ITS203 Object-Oriented Design and Programming
- **Institution:** National Academy of Professional Studies (NAPS)
- **Trimester:** T1 2026