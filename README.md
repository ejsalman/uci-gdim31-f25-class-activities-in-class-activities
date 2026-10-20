# In Class Activities
## Devlogs
### W1
1. When moving Camera outside the Cat GameObject, the camera stays fixed in the position it was last placed in the engine. Pressing the arrow keys still moves the cat, but the camera no longer follows the Cat GameObject and does not respond to player input.
2. https://ejsal.itch.io/w1-in-class-activity

### W2
1. R G and B are all declared as floats since RGB values are measured between 0 and 1, meaning there needs to be a way to store decimal values, which float variables are capable of doing.
2. The _bounce variable is declared as an integer because it is considered "a bounce" whenever the ball makes contact with the cat or the surrounding floor/walls, so the variable then gets incremented by 1.
3. The line was considered broken due to a syntax error. In this instance, it was missing the semi-colon found at the end of C# lines.

### W3
Activity #1     Table #13
1. string GetResponse(int friendshipLevel, bool characterSecret)
   Since we're trying to see if the character can give a certain response to the player, the return type will be string. Friendship level could be a scale of 1-5, and the character's secret would be a yes/no (true/false) value, hence the int and bool types, respectively.
2. void SetLightDimness(float playerSanity)
   The lack of an output means the return type will be void, and the player's sanity being measured as a percentage means it would be represented as a float input.
3. bool DidPlayerHitBeat(float timeKeyPressed)
   We want to know if the player hit the beat on time or not, so return value would be boolean. Time would be measured as a decimal, so float would be the input value.

Activity #2
- Metaphor: Classes (monobehavior ones specifically) and Components are like fraternal twins in the sense that they look different but are the same, with classes being declared and adjusted within a text editor and Components being within the inpsector in engine. Member variables can be considered their DNA; fraternal twins only share 50% of the same DNA, so that same DNA would be the fact that they do the same things within the class and the Component (referred to as Inspector fields), they just look different.

Activity #3
1. I think the balls get extremely bright when bouncing too many times due to using the x and y velocity of the ball as arguments within the Absolute Value method. And since the value of the balls' velocity is multiplied by the speed multiplier every time the balls collide with the walls/ground, the GetColorMultiplier method's arguments change as a result of those calculations, and depending on how high or low the average of the two values end up in relation to _speedThreshold, the ball's RBG values are multiplied by either 1.5 or 1. And, finally, RBG values cannot go beyond 0 and 1.0, so if the product of the existing RGB values and either 1.5 or 1.0 end up being greater than 1.0, it automatically rounds down back to 1.0, making the balls become white the longer they collide with the environment. 

### W4
Table #13
1. We settled on Cat and SoccerBall having collisions and Rigidbodies, and Goal having only a collision with IsTrigger set to true. This is because the goal is a fixed object and doesn't need to move around in the game, but still needs to be passed through by the ball and the cat.
2. I ran into a couple errors during step 6, in which I messed around with how to get the timer to actually work as intended. I tried to declare deltaTime as its own member variable because I forgot that it already existed within the Time class, and that I also didn't need to create the Time class since it already existed in-engine. I mainly thought this way due to Minigame3 requiring us to work within the Timer class, and I mistakenly assumed that I would need to do that again. I got it to work with help from the LAs!