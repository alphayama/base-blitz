# base-blitz
An Augmented Reality (AR) game for Android built on Unity Engine

## Scenes
1. **StartMenu** - The game starts with StartMenu scene. This scene contains the 4 buttons - Play, Settings, Help, Quit. The Play button loads the next scene - ARExample. The Settings button allows the user to choose the difficulty level. There are 3 levels in the game- easy, medium and hard. Eaach difficulty level has a different time limit to complete the game. The Help button provides the user with basic instructions and details about collectibles. The Quit button exits the application.

2. **ARExample** - The scene contains the UI elemets for the user to track and play the game. There is a health bar, progress bar, shoot button, ammunition counter, sheild boost button, reticle pointer (cross-hair). To start the game the user has to scan QR scode of the AR marker to load the enemy base. The ammunition and boosts will be available to collect and the timer will begin once the base loads. The user will be able to shoot at objects  such as anti-aircraft guns, bunkers, radar, and vehices on the ground. The anti- aircraft guns will be shooting at the player and affecting the player's health. The play can replenish health and ammunition  by collecting therespective boosts available throught the game. The user wins the game if they desroy most of the object. The user loses the game if the health becomes zero or the timer runs out.

3. **GameWon** - If the user wins, this scene loads. The scene loads the StartMenu scene after 6 seconds or the user can click on the *Home* button to be redirected.

4. **GameOver** - If the user loses, this scene loads. The scene loads the StartMenu scene after 6 seconds or the user can click on the *Home* button to be redirected.

## Interaction Techniques

User will use their phone to scan an AR Marker (QR Code). We have attached a copy of QR code image with this project. Lay the AR Marker on a flat surface, start the game and scan the code to anchor the military base to the ground.

- Move the phone around to navigate in the game world. 
- There are 2 on-screen buttons: Shoot and Shield (represented by a Shield icon). Shield grants temporary invincibility for few seconds.
- To collect the collectibles, just take your phone near them.

## YouTube Link

[https://youtu.be/6qMpQg-wkOw](https://youtu.be/6qMpQg-wkOw)
