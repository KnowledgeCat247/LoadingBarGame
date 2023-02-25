# Loading Bar Game Code
### Enjoy and Use this code to create whatever you want (Using the Unity Game Engine)
+ The game can be found on Itch.io : [Loading Bar: The Clicker Game](https://knowledgecat247.itch.io/loading-bar-the-clicker-game).
+ The sprites for the game can be found on Itch.io as well: 
___

# How the Sprite Wave Works
This code:
```cs
      yPosition += speed;
      spriteTransform.position = new Vector2(0f + xOffset, (Mathf.Sin(yPosition)/damper) + yIntercept);
```
works as follows
___
 ### 1.
```cs
speed
```
is how much our y increases, it could be 0.1 or it could be 10.

### 2.
```cs
Mathf.Sin(yPosition)/damper) + yIntercept);
```
is a fun little equation,
the equations itself looks like this: (Put Photo here)
and it's simple.

+ The y-intercept is the point on the y-axis (Up and Down) that we want our object to hover around
+ The damper makes sure that the sine wave the object is following doesn't go up and down extremely
+ The the Math Function Sin() (or Sine) makes sure that we have a path to following easily
+ If you want to explore more I made a Desmos graph: [Sine Wave Exploration](https://www.desmos.com/calculator/gmljln3ffb)


