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
Created an Ink material to the project to allow it to match the asthetic of the doc more. I decided to do this because it was a simple and fast way to allow the game to look more asthetically pleasing without spending a decent amount of time doing it. I added this to the player model and the the text in the menus. Added a pause menu to the game that is triggered by the 'P' key. It stops time in the game and activates a pause menu pannel allowing the game to resume or quit with an options menu.  Talked to the designer about adding a quit button to the pause menu and he agreed. I need to add a wave of ink to follow the player which is a good way to test death collisions. Considering whether the the obstacles should only slow the player down as the wave of ink cannot kill the player if the objects do.  

December 7th -  
Added a basic death condition for the player that is triggered by the wave on ink catching up to the player which is constantly following the player that restarts the level. Improved the hitbox of certain obstacles so it doesn't affect the player in certain places. I need to add more tiles to the prefab to make the level gameplay and look more unique as it will be repetitive with the exact same objects. review the scope of online multiplayer. Added a crouch function that reduces the player hitbox allowing the player to crouch under the hole puncher and avoiding the colision and continuing through the map.  
Made the movement appear more look more fluid dispite moving fixed amounts. Added a death screen that that show the player score as well as allowing the player to retry, leave to the menu or wuit the application.  

December 8th -  
Added an a transition available for testing that allows the player to load the next level after a fixed distance. Added a ui pause button that brings up the pasue menu. Created a new prefab that generate planes with a wood texture to be the background  to make it look like the player is on a table and added other objects in the prefabs to make the desk look more cluttered.  

December 9th -  
Added swipe movement that allow the player move based on seiping rather then pressing the keys as this is what would be used on mobile. Added death from obstacles when the player collides. Added a player model based on a ninja with an ink material making it look like the ideal player model in the doc. As well I added a basic running animation to the model as the player moves. Improved elements of the UI with paper backgrounds and minor tweeks in the layout. Added a start screen on the level that stops the player game from starting immediately in case the player is next to an object allowing the player ready themselves before playing. 

December 10th -  
Improved tile spawning to remove clipping issues of textures overlaping with the tiles. Added death from Obstacles and made it so only colliding with an object with tag Obstacles kills the player to avoid any power ups or other objects to do this. Changed the score from distance to a timer which has none of the bug I thought it would. Added a power up that gives the player one free collision without dying but temporarily slows the player down. Encountered a bug where the shield didn't work because it registered multiple collisions so I used the invoke method to allow the player more time to get out of the obstacles way within 2 seconds. Created a script that spawns and destroys the script in the tile spawner after a fixed amount of tile spawns. Updated the game to fit a portrait 16:9 ratio as this is what most phones will use. Added a highscore so the highest score is added to the leaderboard section of the mamin menu.  

December 11th - 
Added a level select to pick the level select and a basic lobby to the game. Added a highscore name that is stored with the highscore based on the name inputed by the player. Added background music to the menu.  

December 12th -  
Added level music and a shield icon that shows  when the player has a power up and dissapears when the player uses their item. Added an Audiomanger to be able to call music and sound effects throughout the project. Added sound effects and connecting the volume slider to the main audio mixer. Added sounds to the menus as well. Added mirror to the project to be able to run multiplayer on a unity framework. Fixed some errors found in testing. Added a multiplayer menu to the menu. https://github.com/VeriorPies/ParrelSync

December 13th - 
Added https://github.com/VeriorPies/ParrelSync to allow multiplayer testing. Added level 2 & 3. Minor fixed.

December 14th - 
Multiplayer Connected and tweeks
Talked To developer about multiplayer Lobby  

Replacing it with a mirror  

Multiplayer Join And Play  
Comments  
Fixes After Testing
Test Case Upload  


