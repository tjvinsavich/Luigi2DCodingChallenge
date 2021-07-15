using System;
using System.Collections.Generic;

namespace LuigiChallenge
{
    public class Luigi
    {
        public Luigi()
        {
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
           string directions = "";

           for (int i = 0; i < map.Length ; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == 0 && j < map[i].Length - 1 && i < map.Length)
                    {
                        if(map[i][j + 1] == 0)
                        {
                            directions += ("Right ");
                        }
                        else if(map[i][j + 1] != 0)
                        {
                            directions += ("Down ");
                        }
                    }
                }
            }

            return directions.Remove(directions.Length - 1);



            //find start point
            //compare to right index (array 1)
            //compare to below index (array 2)

            //if right 0, RIGHT, if !0, DOWN

            //when we go right, stay in current array
            //when we go down, move to next array2 in array1
        }
    }
}
