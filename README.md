# LightsOutGame
This is a tiny game I wrote in VS2013 based on the Lights Out puzzle.
Additionally, the App contains a Level (or Puzzle) Editor which allows the player
to create their own Lights Out puzzle grid and, if it's solvable, to look up its solution.
The project is written entirely in C# (WinForms).

================================================================================

LICENSE:

MIT License

Copyright (c) 2016 Łukasz Furlepa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

================================================================================

NOTE FROM THE AUTHOR:

In order to start the app, you will have to compile it yourself in VS2013 or later.
Simply open the project, press that green arrow and hope for the best ;)

While I do consider the project to be mostly complete, I do recognize a few
bumps that might need improving. The most important piece of code to optimize
is the creation of a bitmap that holds visual information about the puzzle's state -
every time the form is resized or the zoom level is changed, a new bitmap is created.
In worst case scenario (40 x 40 puzzle grid, x6 zoom), it will consist of
(40*96+1) x (40*96+1) = 3841 x 3841 = 14753281 pixels. That's over 56MB of data
in order to display a (tiny!) piece of 40 x 40 (1600 cells) puzzle!
It's completely unnecessary... but it was quick to write and 56MB isn't really
that much. Also, I imagine 40 x 40 puzzles will be quite rare.

I also got lazy with Level Editor's/Solution Form's Solver, where they
share the same Solver instance. I believe this invites a race condition, though
I haven't thought about it too much to be sure.


ABOUT THE GAME:

Well, the rules are simple, if you don't know what the Lights Out puzzle is,
then I advise you to google it :) The name might not sound familiar but I'm
pretty sure that almost everyone has had a chance to have a go at solving
this kind of puzzle. My game spices it up a bit:

- You can define what I call the 'Neighbour Mode'. You can set it to diagonal
  or normal. Normal mode means that only W(estern), E(astern), N(orthern) and 
  S(outhern) cell's neighbours will switch their state when that cell is clicked.
  Diagonal mode means that, in addition to W, E, N, S, the NW, NE, SW and SE
  neighbours will switch as well.

  |     |     |     |
  | --- | --- | --- |
  | NW  |  N  | NE  |
  | W   |  C  |  E  |
  | SW  |  S  | SE  |
  
- I've included 'disabled' lights. Their state can't be changed and clicking them
  will not change their neighbours' states. They are there as a static obstruction.
  With their help, you can create (in Level Editor) different shapes of puzzle grids
  (Not just squares or rectangles).
  
In addition, you can also save your game's state to a file or load it from a file!
The App creates game state files with a .cvlo extension.

There are App settings, although the only thing you can change are the lights' colors.
Sorry, no FOV sliders here.


ABOUT THE LEVEL EDITOR:

The level editor allows for creation of custom puzzles and for calculating and displaying
their solution - if they have one. If your puzzle is solvable, then you can save it to
a file (or load it from a file). The App creates level files with a .cvlolvl extension.
You can then load a level by clicking the Game... >>> New (Premade) button in the main
form's menu.


ANYTHING ELSE?

Not really. This is a tiny project that I lazily wrote in about 5 or 6 days.
It also gives me an opportunity to get used to them GitHub thingies ;p

Have fun! :)
