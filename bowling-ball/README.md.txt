Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces
the total score for the game. Here are some things that the program does not need to do:
• Does not need to check for valid rolls.
• Does not need to check for correct number of rolls and frames.
• Does not need to not provide scores for intermediate frames.
You can find more information about how a bowling game is scored below.


Solution

Approach taken is based on Frames and each frame will have two throws. Last frame will have 3 throws only if 10 poits scored in two throws.
In Spare, score will be calculate using 10 + next throw
In Strike. score will be calculated using 10 + 2 subsequent thorow

- Adhered to solid priciple. Followed Dry
- Used Factory pattern to get instance(Could use Ninject as well)
- Added test cases for all types of combination of frame