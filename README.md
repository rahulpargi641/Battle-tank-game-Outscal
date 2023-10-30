# Battle-tank-game-Outscal

### Introduction
    Battle Tank is a 3D tank game where the player's tank infiltrates enemy territory and must eliminate 
    patrolling enemy tanks. This project prioritizes maintaining code quality and ensuring the game's 
    adaptability for future enhancements.

### Features    
    Core Gameplay:
    - Player tank actions include moving, rotating, and shooting shells.
    - Two types of attacks:
       - Short Range Attack (fire shells from close distance)
       - Ranged Attack (Hold down the left click and shoot shells from greater distance)

    Enemy AI:
    - Enemies patrol the area and chase you when detected, attacking until you are defeated.
    
    Dynamic Camera System:
    - A seamless camera system smoothly tracks the player tank's movements, focusing on detected enemies 
      and returning to the normal view when you are no longer detected.
    
    User Interface (UI):
    - Visually appealing Main Menu, Pause Menu, Game Over, and Level Complete screens.
    - The Pause screen offers convenient options for resuming the game or quitting.
    
### Screenshots

   (Insert screenshots)
  
### Code Structure and Game Design
#### Code Structure

    MVC-S (Model-View-Controller-Service):
        - The codebase is organized using the Model-View-Controller-Service (MVC-S) architectural pattern.
        - This approach maintains a clear separation of concerns:
           - The Model manages data.
           - The View is responsible for UI-related tasks and input handling.
           - The Controller is responsible for updating both the View and Model.
        - Classes for PlayerTank, EnemyTank, Camera, Shell, Level, GameUI, have been implemented following
          the MVC pattern.

    Singletons:
        - Centralized control is ensured through the implementation of Singleton patterns.
        - Essential services such as PlayerService, EnemyService, CameraService, ShellService, AudioService, 
          ParticleSystem Service, GameUIService, LevelService are designed as Singletons.
          
    State Pattern:
        - Utilized the state pattern to manage enemy states sucn as idle, run, patrol, pursue, attack.
    
    Observer Pattern:
        - Utilized the observer pattern for decoupling classes and handling events such as player death, 
          enemy destruction, shots fired, and level completion.
        - This pattern enables communication between different game components, notifying the achievement system
          of enemy destruction, notifying level completion when all enemies are defeated, and managing the 
          game over screen activation.
          
    Scriptable Objects:
         - Scriptable objects were used for configuring player and enemy tanks efficiently, allowing for flexibility
           in handling their attributes and tank types..
       
#### Performance Optimization:
    - To optimize performance, object pooling is used for enemies, shells, and various particle VFX, efficiently 
      managing memory and CPU usage.

#### Level Design:
    - Designed using Unity's Battle Tank base artwork.
    - Strategically placed enemy tanks throughout the patrolling area to prevent intruders from infiltrating..

#### Enchanced Camera Tracking
    - Developed custom logic for the camera system to smoothly track the player tank's movements.
    - When enemies are detected, the camera automatically focuses on them, reverting to the normal view once you are
      no longer detected.
    
### Dynamic Camera System
    - Code Quality and Organization.
    - Architecture Design for Flexibility and Scalability.
    
### Gameplay Demonstration
    For a visual demonstration of the gameplay, watch video on YouTube.
    
### Play the Game
    To experience the game firsthand, play it directly by following this playable link.

### Credits
#### Assets
- Character Models and Game Map: [Instructor's Name](link-to-instructor-profile)