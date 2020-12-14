November 16th -
I created a temporary plane to test player movement. I then added a basic player model of a cylinder to test the player movement script.  
Then I created a basic script that moves the player forward at a constant rate which will serve the constant movement for the endless runner. The first problem is  
while testing the player will eventually fall off and making the plane longer will not be optimal. I have decided to look into spawning/generation to deal with this.  
The playerMovement script only takes movement on the horizontal axis as this will achieve a fixed movement to avoid collision with obstacles later on.    

November 24th -
Added a CameraFollow script that allows the camera to follow the player which is ideal for endless runners.  
Updated the movement to move left and right a fixed amount like other endless runners to quickly avoid obstacles. This also makes spawning obstacles  
much easier as They will only need to spawn in 3 locations the middle, left or right.  
Added Jumping whichh will be used to avoid smaller obstacles later on.  
Player Continues to rise so i added grvity in the player movement script rather then the rigidbody as this allows me to customise it to tweek the jumping and making it tighter later on. I also changed the movemment to only go left and right till they make it to the final lane on their respective sides.  

November 29th - 
After researching spawning planes and decided on creating tiles to spawn that will add spawn in a random order at a fixed distance to create a different track every time. I used blender to create a notepad asset to serve as the ground for all the tiles. This took longer than expected and I talked to the designer about needing to use simpler assets as it's to time consuming to make the more specific assets and so I need to use ones available from the asset store.  

I created Tiles with the notepad from blender with objects from the design doc.  https://assetstore.unity.com/packages/3d/props/office-supplies-low-poly-105519  
These prefabs include objects suited for jumping. avoiding and ssliding under to make the core gameplay of the game. Need to add Death collisions later on as they only slow the player at the moment.


Tiles Randomly generate infinitely.
Collisions, Death screen and Menus need to be implemented.  

Main menu with play & quit functions working.  
Options menu implemented with no functionality

Talked to game designer about the importance of the asthetics and leaving them to last as designing assets in blender slows done development(Through email).

Added basic score.  
Talked with Designer about swapping the timer with a distance counter for better gameflow.  
Need to add Game over screen, improved collisions and more tiles.  
  
Updated Menu with Ink Fonts.  
Added Pause Menu.  
Talked with designer about adding a quit to menu button.  
Need to add ink to follow player. 
Improve collisions that slow the player and death from ink.  
Talk to designer about lives vs slow  
Need to add more tiles andd extra levels.  
Multiplayer add ghost, talk to designer about the scope of multiplayer being too big if other projects get in the way  

Added crouch,  
improved movement  


Game over Screen  
Ink kills Player  
  
Level complete and transition  
Added Pause button  
Generates Table for background    
  
Swipe Controls  
Improved Tile Spawning  
Added Death From Obstacles  
Changed Score to a Timer like the designer wanted  
Added a Power up that gives the user a life  
Encountered Bug where multiple collisions caused the power to not work as intended  
Fixed Power Up  
Updated camera for phone aspect ratio  
Added High score to main menu  

https://github.com/VeriorPies/ParrelSync(Testing Multiplayer)  
Added a level Select  
Created a lobby  
Save Player name to Highscore  
Added Background music  

Added Level Music and Shield Icon 
Added Audio Manager To replace Triggers Sounds 
Sound Effects  
Menu Sounds  
Fixed Bug With Collisions in testing  
Master Audio Slider  
Multiplayer Menu  

Level2  
Multiplayer & Mirror added  
Level 3  
Minor Fixes  

Talked To developer about multiplayer Lobby  
Replacing it with a mirror  
Multiplayer Join And Play  
Comments  
Fixes After Testing
Test Cae Upload  
