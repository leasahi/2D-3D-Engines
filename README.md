Documentation:

Lea Sahiner implemented:
- Platform animation: I created an animation clip and an animator controller. In the clip, I animated a 360-degree rotation and an up-and-down movement by keying the Y value. I added the clip to the animator, where it’s connected to “Entry,” so the animation starts as soon as the game begins.
- Animation event: For this, I created a script with two functions to set the materials. Then, in the Animation window, I created animation events corresponding to the correct keys and assigned which function each event should trigger.
- More Energy!: I added the solar panels on both sides as children to the spaceship GameObject, positioned them properly on the spaceship, created a Solar Panel Animator Controller where I rotate the panels and loop the animation clip. Then, I duplicated the solar panel’s material and animated the Emission Color from 0 to 2 intensity using the same animation clip.

Thorben Staufer implemented:
- Character animations: I downloaded 4 3D models and dance animations from mixamo.com, adjusted their import settings and put them on the animated platform with their animation on loop.
- Spaceship interaction: I created an empty game object with a spherical collider as a child of the platform, which triggers custom PlayerInRange and PlayerOutOfRange events via the DanceParty script. The Dancer script on the 4 dancers has two respective event handlers that are added as listeners to the DanceParty object which will set animation parameters and rotate the models towards the player ship. The boolean inRange animation paramater causes the dancers to transition from/to a wave animation, which was also downloaded from mixamo.com.
