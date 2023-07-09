# Project Description

The Maze student project (*work in progress*) is a Unity game where players navigate through a maze, collecting bonuses and avoiding dangers. The goal of the game is to find the exit of the maze with the highest possible bonus score.

## Components

### Classes

1. **Main**: The main class of the game, responsible for managing the gameplay and coordinating other components.
2. **Unit**: An abstract class representing a game object with position, speed, and health. It serves as a base class for the player and bonus objects.
3. **Player**: A class representing the player. It handles player movement and interactions with other objects.
4. **Bonus**: An abstract class representing a bonus object in the game. It has subclasses for different types of bonuses.
5. **GoodBonus**: A class representing a positive bonus. The player earns points when interacting with it.
6. **BadBonus**: A class representing a negative bonus. The player loses health or loses the game when interacting with it.
7. **LevelObjectView**: A class representing the view of level objects in the game. It holds references to the Transform, Collider, and Renderer components of the object.

### Interfaces

1. **IFlicker**: Defines the Flick() method, allowing an object to flicker or change its appearance at a certain frequency or pattern.
2. **IFly**: Defines the Fly() method, allowing an object to move in the vertical direction.
3. **IRotation**: Defines the Rotate() method, allowing an object to rotate around its axis or other objects.
4. **ISaveData**: Defines methods for saving and loading game data.

### View Components

1. **ViewBonus**: A class representing the view of bonus objects in the game. It displays information about the bonus in a UI element.
2. **ViewEndGame**: A class representing the view of the game over screen in the game. It displays information about the end of the game in a UI element.

### Other Components

1. **ListExecuteObjectController**: A class that manages a list of objects that need to execute specific actions every frame.
2. **InputController**: A class that handles player input and controls the player's movement.
3. **CameraController**: A class that controls the position and rotation of the camera relative to the player.

## Applied Design Approaches

1. **Single Responsibility Principle**: Each class has a single primary responsibility.
2. **Open/Closed Principle**: The classes are designed to be open for extension and closed for modification.
3. **Interface**: Interfaces are used to define contracts and common methods between different classes.
4. **Encapsulation**: Classes have well-defined public and private members, providing controlled access to their functionality.
5. **Events**: Events are used to implement communication between different game components.
6. **External Resources**: Resources like object prefabs and UI elements are loaded from external files and used during the game runtime.
7. **Observer Pattern**: The use of events and delegates allows implementing the Observer pattern for notifying and reacting to specific events in the game.

Adding these design approaches to the above description will help readers better understand the architecture and structure of the project, as well as the applied development principles. It will enable developers and other interested individuals to more easily grasp and make modifications to the project, as well as create new components following the established principles and project structure.