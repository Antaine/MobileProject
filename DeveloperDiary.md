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
These prefabs include objects suited for jumping. avoiding and sliding under to make the core gameplay of the game. Need to add Death collisions later on as they only slow the player at the moment.  
Tiles now generate infinitely allowing hte player to run endlessly. This a vital part of the project that was not a complex as it seems at first. They also generate randomly allowing the game to remain fresh. Death Collisions Still need to be added.   

December 2nd -  
Added a basic main menus that allows the player to load level 1 or quit the game. It still needs to be stylized which I am going to leave till after the functionality is completed. I then added the template of the options menu with no functionality at the moment as the audio slider cannot be tested till music is added to the game.    

Talked to designer over email that I will focus on the fuctionality and do the asthetics later and things like the menu and UI may remain simple if there is not enough time.  
December 3rd -  
Added a basic score system that currently takes in the player distance to update a score element in hud of the player giving a sense of progress. This will be changed to a timer later on in development and tested to make sure no elements such as dying or pausing interfer with this when they are added. I will look into this more.  
Considered keeping the distance over the timer but after reviewing the game doc I believe the timer suits the game more.  
Need to add Game over screen, improved collisions and more tiles.  

December 5th -  

Updated Menu with Ink
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
