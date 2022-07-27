# LaserDefender-2D-Game
LaserDefender 2D Unity game - Space shooter, Avoid waves of enemies for as long as possible, Shoot enemies to score points 

Game Design Document: Bigger game = more detailed GDD

#### Concept
    1.  Space shooter
    2.  Avoid waves of enemies for as long as possible
    3.  Shoot enemies to score points 

#### Game Design: 
    - Theme: 
      Space Shooter

    - Player Experience: 
      Frantic
    
    - Core Mechanic: 
      Shoot enemies - Dodge bullets
    
    - Game Loop:
      Single level with endless enemy waves
      Shoot enemies for points until health reaches zero and game ends
    
#### Art Assets:
    - Player ship
    - Multiple enemy ships
    - Projectiles (player & enemy)
    - Background sprites
    - Fonts
    - UI sprites
    
![image](https://user-images.githubusercontent.com/23366804/181375087-64b542b8-406a-4f3e-8b74-97e89a837029.png)
#### Viewport:
    - Viewport space represents a normalized position relative to the camera
    - ViewportToWorldPoint converts a normalized position on the screen to a in 3D position in 
world space

## Enemies and Waves
  #### Enemies
    - Cause damage to the player
    - Can have different attack behaviours
    - Affect the players score
    - Spawned in waves
  #### Waves 
    - Self-contained “moment” of gameplay
    - Spawn n enemies over time
    - Enemies follow a set path
 
![image](https://user-images.githubusercontent.com/23366804/181375305-82073011-cbfb-47b0-88c4-c94a7b480a52.png)
## Scripts and Responsibilities
Wave Config:
  - Which enemies will be spawned
  - The path to be followed
  - Time between enemy spawns
  - Enemy movement speed

Enemy Spawner:
  - Spawn enemy
  - Order of the waves
  - Time between waves

Enemy Pathing:
  - Moves enemy along the path

![image](https://user-images.githubusercontent.com/23366804/181375374-1ba5ca92-fa88-4b0a-bde5-6b6dada9f83d.png)
#### Parallax Scrolling
  - Multiple image layers scrolling at different speeds
  - Gives an artificial sense of depth
  - More layers give more depth

#### Audio in Three Parts
  1. Audio File: The `sounds` that get played
  2. Audio Source: To `play` the audio
  3. Audio Listener: To `hear` the audio

## Game UI
1. Health
    - Slider
    - Heart containers
    - Text
    - Change player sprite
2. Score
    - Text
3. Other stuff
    - Current wave
    - Active powerups
    - Playtime
