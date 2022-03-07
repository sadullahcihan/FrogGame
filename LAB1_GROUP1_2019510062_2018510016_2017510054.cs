using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.CursorVisible = false;
            int randomizer = 0;
            int amount_of_vehicle1 = 10;
            bool game = true;
            int amount_of_vehicle2 = 2;
            string frog_direction = "";
            int frog_x = 24, frog_y = 5;
            int[] right_controller2 = new int[amount_of_vehicle2];
            int[] right_controller1 = new int[amount_of_vehicle1];
            int[] left_controller2 = new int[amount_of_vehicle2];
            int[] left_controller1 = new int[amount_of_vehicle1];
            int[] position_of_rightvehicle2 = new int[amount_of_vehicle2];
            int[] length_of_rightvehicle2 = new int[amount_of_vehicle2];
            int[] position_of_leftvehicle2 = new int[amount_of_vehicle2];
            int[] length_of_leftvehicle2 = new int[amount_of_vehicle2];
            int[] position_of_rightvehicle1 = new int[amount_of_vehicle1];
            int[] length_of_rightvehicle1 = new int[amount_of_vehicle1];
            int[] position_of_leftvehicle1 = new int[amount_of_vehicle1];
            int[] length_of_leftvehicle1 = new int[amount_of_vehicle1];
            int[] right_vehicle2 = new int[amount_of_vehicle2];
            int[] left_vehicle2 = new int[amount_of_vehicle2];
            int[] left_vehicle1 = new int[amount_of_vehicle1];
            int[] right_vehicle1 = new int[amount_of_vehicle1];
            char[] border1 = new char[51];
            char[] border2 = new char[51];
            char[] road1 = new char[50];
            char[] road2 = new char[50];
            char[] road3 = new char[50];
            char[] road4 = new char[50];
            int time = 0;
            int level = 1;
            int score = 60;
            int life = 1;
            int car_placement_counter = 0;
            int level_score = 0;

            for (int i = 0; i < border1.Length; i++)    //Road arrays
            {
                border1[i] = '-';
            }
            for (int i = 0; i < border2.Length; i++)
            {
                border2[i] = '-';
            }
            for (int i = 0; i < road1.Length; i++)
            {
                road1[i] = '.';
            }
            for (int i = 0; i < road2.Length; i++)
            {
                road2[i] = '.';
            }
            for (int i = 0; i < road3.Length; i++)
            {
                road3[i] = '.';
            }
            for (int i = 0; i < road4.Length; i++)
            {
                road4[i] = '.';
            }


            while (game)
            {
                randomizer = 0;
                if (car_placement_counter == 24) //Writing roads and screen.
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i < border1.Length; i++)
                    {
                        Console.Write(border1[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i <= road1.Length; i++)
                    {
                        if (i != 50)
                            Console.Write(road1[i]);
                        if (i == 50)
                            Console.Write("<<");
                    }
                    Console.WriteLine();
                    for (int i = 0; i <= road2.Length; i++)
                    {
                        if (i != 50)
                            Console.Write(road2[i]);
                        if (i == 50)
                            Console.Write("<<");
                    }
                    Console.WriteLine();
                    for (int i = 0; i <= road3.Length; i++)
                    {
                        if (i != 50)
                            Console.Write(road3[i]);
                        if (i == 50)
                            Console.Write(">>");
                    }
                    Console.WriteLine();
                    for (int i = 0; i <= road4.Length; i++)
                    {
                        if (i != 50)
                            Console.Write(road4[i]);
                        if (i == 50)
                            Console.Write(">>");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < border2.Length; i++)
                    {
                        Console.Write(border2[i]);
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(5, 6);
                    Console.Write("Time: " + time);
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Level: " + level);
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Frog direction: " + frog_direction);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Score: " + score);
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("Life: " + life);

                }

                if (car_placement_counter != 24)
                {

                    for (int i = 0; i < amount_of_vehicle2; i++) // Type 2 cars which moving to the left.

                    {

                        if (left_controller2[i] != 1)
                        {
                            randomizer = rnd.Next(1, 46);
                            position_of_leftvehicle2[i] = randomizer;
                            randomizer = rnd.Next(2, 5);
                            length_of_leftvehicle2[i] = randomizer;
                            randomizer = rnd.Next(1, 3);
                            left_vehicle2[i] = randomizer;

                            if (left_vehicle2[i] == 1) // For the road 1.
                            {
                                if ((length_of_leftvehicle2[i] == 2) && (road1[position_of_leftvehicle2[i] - 1] == '.') && (road1[position_of_leftvehicle2[i]] == '.') && (road1[position_of_leftvehicle2[i] + 1] == '.') && (road1[position_of_leftvehicle2[i] + 2] == '.'))
                                {

                                    left_controller2[i] = 1;
                                    road1[position_of_leftvehicle2[i]] = '2';
                                    road1[position_of_leftvehicle2[i] + 1] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle2[i] == 3) && (road1[position_of_leftvehicle2[i] - 1] == '.') && (road1[position_of_leftvehicle2[i]] == '.') && (road1[position_of_leftvehicle2[i] + 1] == '.') && (road1[position_of_leftvehicle2[i] + 2] == '.') && (road1[position_of_leftvehicle2[i] + 3] == '.'))
                                {


                                    left_controller2[i] = 1;
                                    road1[position_of_leftvehicle2[i]] = '2';
                                    road1[position_of_leftvehicle2[i] + 1] = '2';
                                    road1[position_of_leftvehicle2[i] + 2] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle2[i] == 4) && (road1[position_of_leftvehicle2[i] - 1] == '.') && (road1[position_of_leftvehicle2[i]] == '.') && (road1[position_of_leftvehicle2[i] + 1] == '.') && (road1[position_of_leftvehicle2[i] + 2] == '.') && (road1[position_of_leftvehicle2[i] + 3] == '.') && (road1[position_of_leftvehicle2[i] + 4] == '.'))
                                {

                                    left_controller2[i] = 1;
                                    road1[position_of_leftvehicle2[i]] = '2';
                                    road1[position_of_leftvehicle2[i] + 1] = '2';
                                    road1[position_of_leftvehicle2[i] + 2] = '2';
                                    road1[position_of_leftvehicle2[i] + 3] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                            }


                            else if (left_vehicle2[i] == 2)//For the road 2.
                            {
                                if ((length_of_leftvehicle2[i] == 2) && (road2[position_of_leftvehicle2[i] - 1] == '.') && (road2[position_of_leftvehicle2[i]] == '.') && (road2[position_of_leftvehicle2[i] + 1] == '.') && (road2[position_of_leftvehicle2[i] + 2] == '.'))
                                {

                                    left_controller2[i] = 1;
                                    road2[position_of_leftvehicle2[i]] = '2';
                                    road2[position_of_leftvehicle2[i] + 1] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle2[i] == 3) && (road2[position_of_leftvehicle2[i] - 1] == '.') && (road2[position_of_leftvehicle2[i]] == '.') && (road2[position_of_leftvehicle2[i] + 1] == '.') && (road2[position_of_leftvehicle2[i] + 2] == '.') && (road2[position_of_leftvehicle2[i] + 3] == '.'))
                                {


                                    left_controller2[i] = 1;
                                    road2[position_of_leftvehicle2[i]] = '2';
                                    road2[position_of_leftvehicle2[i] + 1] = '2';
                                    road2[position_of_leftvehicle2[i] + 2] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle2[i] == 4) && (road2[position_of_leftvehicle2[i] - 1] == '.') && (road2[position_of_leftvehicle2[i]] == '.') && (road2[position_of_leftvehicle2[i] + 1] == '.') && (road2[position_of_leftvehicle2[i] + 2] == '.') && (road2[position_of_leftvehicle2[i] + 3] == '.') && (road2[position_of_leftvehicle2[i] + 4] == '.'))
                                {

                                    left_controller2[i] = 1;
                                    road2[position_of_leftvehicle2[i]] = '2';
                                    road2[position_of_leftvehicle2[i] + 1] = '2';
                                    road2[position_of_leftvehicle2[i] + 2] = '2';
                                    road2[position_of_leftvehicle2[i] + 3] = '2';
                                    car_placement_counter = car_placement_counter + 1;

                                }

                            }
                        }
                        if (left_controller2[i] != 1) //In order to go back to the for loop in case cars are not placed.
                            i = i - 1;






                    }

                    for (int i = 0; i < amount_of_vehicle1; i++) //Type 1 cars which moving to the left.
                    {

                        if (left_controller1[i] != 1)
                        {
                            randomizer = rnd.Next(1, 46);
                            position_of_leftvehicle1[i] = randomizer;
                            randomizer = rnd.Next(2, 5);
                            length_of_leftvehicle1[i] = randomizer;
                            randomizer = rnd.Next(1, 3);
                            left_vehicle1[i] = randomizer;

                            if (left_vehicle1[i] == 1) //For the road 1.
                            {
                                if ((length_of_leftvehicle1[i] == 2) && (road1[position_of_leftvehicle1[i] - 1] == '.') && (road1[position_of_leftvehicle1[i]] == '.') && (road1[position_of_leftvehicle1[i] + 1] == '.') && (road1[position_of_leftvehicle1[i] + 2] == '.'))
                                {

                                    left_controller1[i] = 1;
                                    road1[position_of_leftvehicle1[i]] = '1';
                                    road1[position_of_leftvehicle1[i] + 1] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle1[i] == 3) && (road1[position_of_leftvehicle1[i] - 1] == '.') && (road1[position_of_leftvehicle1[i]] == '.') && (road1[position_of_leftvehicle1[i] + 1] == '.') && (road1[position_of_leftvehicle1[i] + 2] == '.') && (road1[position_of_leftvehicle1[i] + 3] == '.'))
                                {


                                    left_controller1[i] = 1;
                                    road1[position_of_leftvehicle1[i]] = '1';
                                    road1[position_of_leftvehicle1[i] + 1] = '1';
                                    road1[position_of_leftvehicle1[i] + 2] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle1[i] == 4) && (road1[position_of_leftvehicle1[i] - 1] == '.') && (road1[position_of_leftvehicle1[i]] == '.') && (road1[position_of_leftvehicle1[i] + 1] == '.') && (road1[position_of_leftvehicle1[i] + 2] == '.') && (road1[position_of_leftvehicle1[i] + 3] == '.') && (road1[position_of_leftvehicle1[i] + 4] == '.'))
                                {

                                    left_controller1[i] = 1;
                                    road1[position_of_leftvehicle1[i]] = '1';
                                    road1[position_of_leftvehicle1[i] + 1] = '1';
                                    road1[position_of_leftvehicle1[i] + 2] = '1';
                                    road1[position_of_leftvehicle1[i] + 3] = '1';
                                    car_placement_counter = car_placement_counter + 1;

                                }
                            }


                            if (left_vehicle1[i] == 2) //For the road 2.
                            {
                                if ((length_of_leftvehicle1[i] == 2) && (road2[position_of_leftvehicle1[i] - 1] == '.') && (road2[position_of_leftvehicle1[i]] == '.') && (road2[position_of_leftvehicle1[i] + 1] == '.') && (road2[position_of_leftvehicle1[i] + 2] == '.'))
                                {

                                    left_controller1[i] = 1;
                                    road2[position_of_leftvehicle1[i]] = '1';
                                    road2[position_of_leftvehicle1[i] + 1] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle1[i] == 3) && (road2[position_of_leftvehicle1[i] - 1] == '.') && (road2[position_of_leftvehicle1[i]] == '.') && (road2[position_of_leftvehicle1[i] + 1] == '.') && (road2[position_of_leftvehicle1[i] + 2] == '.') && (road2[position_of_leftvehicle1[i] + 3] == '.'))
                                {


                                    left_controller1[i] = 1;
                                    road2[position_of_leftvehicle1[i]] = '1';
                                    road2[position_of_leftvehicle1[i] + 1] = '1';
                                    road2[position_of_leftvehicle1[i] + 2] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_leftvehicle1[i] == 4) && (road2[position_of_leftvehicle1[i] - 1] == '.') && (road2[position_of_leftvehicle1[i]] == '.') && (road2[position_of_leftvehicle1[i] + 1] == '.') && (road2[position_of_leftvehicle1[i] + 2] == '.') && (road2[position_of_leftvehicle1[i] + 3] == '.') && (road2[position_of_leftvehicle1[i] + 4] == '.'))
                                {

                                    left_controller1[i] = 1;
                                    road2[position_of_leftvehicle1[i]] = '1';
                                    road2[position_of_leftvehicle1[i] + 1] = '1';
                                    road2[position_of_leftvehicle1[i] + 2] = '1';
                                    road2[position_of_leftvehicle1[i] + 3] = '1';
                                    car_placement_counter = car_placement_counter + 1;

                                }

                            }
                        }
                        if (left_controller1[i] != 1) //In order to go back to the for loop in case cars are not placed.
                            i = i - 1;

                    }
                    for (int i = 0; i < amount_of_vehicle2; i++) // Type 2 cars which moving to the right.

                    {

                        if (right_controller2[i] != 1)
                        {
                            randomizer = rnd.Next(1, 46);
                            position_of_rightvehicle2[i] = randomizer;
                            randomizer = rnd.Next(2, 5);
                            length_of_rightvehicle2[i] = randomizer;
                            randomizer = rnd.Next(3, 5);
                            right_vehicle2[i] = randomizer;

                            if (right_vehicle2[i] == 3) //For the road 3.
                            {
                                if ((length_of_rightvehicle2[i] == 2) && (road3[position_of_rightvehicle2[i] - 1] == '.') && (road3[position_of_rightvehicle2[i]] == '.') && (road3[position_of_rightvehicle2[i] + 1] == '.') && (road3[position_of_rightvehicle2[i] + 2] == '.'))
                                {

                                    right_controller2[i] = 1;
                                    road3[position_of_rightvehicle2[i]] = '2';
                                    road3[position_of_rightvehicle2[i] + 1] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle2[i] == 3) && (road3[position_of_rightvehicle2[i] - 1] == '.') && (road3[position_of_rightvehicle2[i]] == '.') && (road3[position_of_rightvehicle2[i] + 1] == '.') && (road3[position_of_rightvehicle2[i] + 2] == '.') && (road1[position_of_rightvehicle2[i] + 3] == '.'))
                                {


                                    right_controller2[i] = 1;
                                    road3[position_of_rightvehicle2[i]] = '2';
                                    road3[position_of_rightvehicle2[i] + 1] = '2';
                                    road3[position_of_rightvehicle2[i] + 2] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle2[i] == 4) && (road3[position_of_rightvehicle2[i] - 1] == '.') && (road3[position_of_rightvehicle2[i]] == '.') && (road3[position_of_rightvehicle2[i] + 1] == '.') && (road3[position_of_rightvehicle2[i] + 2] == '.') && (road3[position_of_rightvehicle2[i] + 3] == '.') && (road3[position_of_rightvehicle2[i] + 4] == '.'))
                                {

                                    right_controller2[i] = 1;
                                    road3[position_of_rightvehicle2[i]] = '2';
                                    road3[position_of_rightvehicle2[i] + 1] = '2';
                                    road3[position_of_rightvehicle2[i] + 2] = '2';
                                    road3[position_of_rightvehicle2[i] + 3] = '2';
                                    car_placement_counter = car_placement_counter + 1;

                                }
                            }


                            else if (right_vehicle2[i] == 4) //For the road 4.
                            {
                                if ((length_of_rightvehicle2[i] == 2) && (road4[position_of_rightvehicle2[i] - 1] == '.') && (road4[position_of_rightvehicle2[i]] == '.') && (road4[position_of_rightvehicle2[i] + 1] == '.') && (road4[position_of_rightvehicle2[i] + 2] == '.'))
                                {

                                    right_controller2[i] = 1;
                                    road4[position_of_rightvehicle2[i]] = '2';
                                    road4[position_of_rightvehicle2[i] + 1] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle2[i] == 3) && (road4[position_of_rightvehicle2[i] - 1] == '.') && (road4[position_of_rightvehicle2[i]] == '.') && (road4[position_of_rightvehicle2[i] + 1] == '.') && (road4[position_of_rightvehicle2[i] + 2] == '.') && (road4[position_of_rightvehicle2[i] + 3] == '.'))
                                {


                                    right_controller2[i] = 1;
                                    road4[position_of_rightvehicle2[i]] = '2';
                                    road4[position_of_rightvehicle2[i] + 1] = '2';
                                    road4[position_of_rightvehicle2[i] + 2] = '2';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle2[i] == 4) && (road4[position_of_rightvehicle2[i] - 1] == '.') && (road4[position_of_rightvehicle2[i]] == '.') && (road4[position_of_rightvehicle2[i] + 1] == '.') && (road4[position_of_rightvehicle2[i] + 2] == '.') && (road4[position_of_rightvehicle2[i] + 3] == '.') && (road4[position_of_rightvehicle2[i] + 4] == '.'))
                                {

                                    right_controller2[i] = 1;
                                    road4[position_of_rightvehicle2[i]] = '2';
                                    road4[position_of_rightvehicle2[i] + 1] = '2';
                                    road4[position_of_rightvehicle2[i] + 2] = '2';
                                    road4[position_of_rightvehicle2[i] + 3] = '2';
                                    car_placement_counter = car_placement_counter + 1;

                                }

                            }
                            if (right_controller2[i] != 1) //In order to go back to the for loop in case cars are not placed.
                                i = i - 1;
                        }

                    }


                    for (int i = 0; i < amount_of_vehicle1; i++) //Type 1 cars which moving to the right.
                    {

                        if (right_controller1[i] != 1)
                        {
                            randomizer = rnd.Next(1, 46);
                            position_of_rightvehicle1[i] = randomizer;
                            randomizer = rnd.Next(2, 5);
                            length_of_rightvehicle1[i] = randomizer;
                            randomizer = rnd.Next(3, 5);
                            right_vehicle1[i] = randomizer;

                            if (right_vehicle1[i] == 3) //For the road 3.
                            {
                                if ((length_of_rightvehicle1[i] == 2) & (road3[position_of_rightvehicle1[i] - 1] == '.') & (road3[position_of_rightvehicle1[i]] == '.') & (road3[position_of_rightvehicle1[i] + 1] == '.') & (road3[position_of_rightvehicle1[i] + 2] == '.'))
                                {

                                    right_controller1[i] = 1;
                                    road3[position_of_rightvehicle1[i]] = '1';
                                    road3[position_of_rightvehicle1[i] + 1] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle1[i] == 3) & (road3[position_of_rightvehicle1[i] - 1] == '.') & (road3[position_of_rightvehicle1[i]] == '.') & (road3[position_of_rightvehicle1[i] + 1] == '.') & (road3[position_of_rightvehicle1[i] + 2] == '.') & (road3[position_of_rightvehicle1[i] + 3] == '.'))
                                {


                                    right_controller1[i] = 1;
                                    road3[position_of_rightvehicle1[i]] = '1';
                                    road3[position_of_rightvehicle1[i] + 1] = '1';
                                    road3[position_of_rightvehicle1[i] + 2] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle1[i] == 4) & (road3[position_of_rightvehicle1[i] - 1] == '.') & (road3[position_of_rightvehicle1[i]] == '.') & (road3[position_of_rightvehicle1[i] + 1] == '.') & (road3[position_of_rightvehicle1[i] + 2] == '.') & (road3[position_of_rightvehicle1[i] + 3] == '.') & (road3[position_of_rightvehicle1[i] + 4] == '.'))
                                {

                                    right_controller1[i] = 1;
                                    road3[position_of_rightvehicle1[i]] = '1';
                                    road3[position_of_rightvehicle1[i] + 1] = '1';
                                    road3[position_of_rightvehicle1[i] + 2] = '1';
                                    road3[position_of_rightvehicle1[i] + 3] = '1';
                                    car_placement_counter = car_placement_counter + 1;

                                }


                            }


                            else if (right_vehicle1[i] == 4) //For the road 4.
                            {
                                if ((length_of_rightvehicle1[i] == 2) && (road4[position_of_rightvehicle1[i] - 1] == '.') && (road4[position_of_rightvehicle1[i]] == '.') && (road4[position_of_rightvehicle1[i] + 1] == '.') && (road4[position_of_rightvehicle1[i] + 2] == '.'))
                                {

                                    right_controller1[i] = 1;
                                    road4[position_of_rightvehicle1[i]] = '1';
                                    road4[position_of_rightvehicle1[i] + 1] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle1[i] == 3) && (road4[position_of_rightvehicle1[i] - 1] == '.') && (road4[position_of_rightvehicle1[i]] == '.') && (road4[position_of_rightvehicle1[i] + 1] == '.') && (road4[position_of_rightvehicle1[i] + 2] == '.') && (road4[position_of_rightvehicle1[i] + 3] == '.'))
                                {


                                    right_controller1[i] = 1;
                                    road4[position_of_rightvehicle1[i]] = '1';
                                    road4[position_of_rightvehicle1[i] + 1] = '1';
                                    road4[position_of_rightvehicle1[i] + 2] = '1';
                                    car_placement_counter = car_placement_counter + 1;
                                }
                                else if ((length_of_rightvehicle1[i] == 4) && (road4[position_of_rightvehicle1[i] - 1] == '.') && (road4[position_of_rightvehicle1[i]] == '.') && (road4[position_of_rightvehicle1[i] + 1] == '.') && (road4[position_of_rightvehicle1[i] + 2] == '.') && (road4[position_of_rightvehicle1[i] + 3] == '.') && (road4[position_of_rightvehicle1[i] + 4] == '.'))
                                {

                                    right_controller1[i] = 1;
                                    road4[position_of_rightvehicle1[i]] = '1';
                                    road4[position_of_rightvehicle1[i] + 1] = '1';
                                    road4[position_of_rightvehicle1[i] + 2] = '1';
                                    road4[position_of_rightvehicle1[i] + 3] = '1';
                                    car_placement_counter = car_placement_counter + 1;

                                }

                            }
                            if (right_controller1[i] != 1)//In order to go back to the for loop in case cars are not placed.
                                i = i - 1;
                        }




                    }
                }



                if (car_placement_counter == 24)
                {
                    frog_direction = "                    ";
                    while (Console.KeyAvailable)                                        //Moving the frog.
                    {

                        ConsoleKeyInfo movement = Console.ReadKey();

                        if (movement.Key == ConsoleKey.RightArrow)
                        {
                            frog_direction = "                        ";
                            if (frog_x == 49)
                            { }
                            else
                            {
                                if (frog_y == 4)
                                {

                                    if (road4[frog_x + 1] == '.')
                                    {
                                        road4[frog_x] = '.';
                                        frog_x = frog_x + 1;
                                    }
                                }
                                else if (frog_y == 3)
                                {
                                    if (road3[frog_x + 1] == '.')
                                    {
                                        road3[frog_x] = '.';
                                        frog_x = frog_x + 1;
                                    }
                                }
                                else if (frog_y == 2)
                                {
                                    if (road2[frog_x + 1] == '.')
                                    {
                                        road2[frog_x] = '.';
                                        frog_x = frog_x + 1;
                                    }
                                }
                                else if (frog_y == 1)
                                {
                                    if (road1[frog_x + 1] == '.')
                                    {
                                        road1[frog_x] = '.';
                                        frog_x = frog_x + 1;
                                    }
                                }
                                else if (frog_y == 0)
                                {
                                    if (border1[frog_x + 1] == '-')
                                    {
                                        border1[frog_x] = '-';
                                        frog_x = frog_x + 1;
                                    }
                                }

                                else
                                {
                                    if (border2[frog_x + 1] == '-')
                                    {
                                        border2[frog_x] = '-';
                                        frog_x = frog_x + 1;
                                    }
                                }
                                frog_direction = "Right";

                            }
                            break;
                        }
                        else if (movement.Key == ConsoleKey.LeftArrow)
                        {
                            if (frog_x == 0)
                            { }
                            else
                            {
                                frog_direction = "                      ";
                                if (frog_y == 4)
                                {

                                    if (road4[frog_x - 1] == '.')
                                    {
                                        road4[frog_x] = '.';
                                        frog_x = frog_x - 1;
                                    }
                                }
                                else if (frog_y == 3)
                                {
                                    if (road3[frog_x - 1] == '.')
                                    {
                                        road3[frog_x] = '.';
                                        frog_x = frog_x - 1;
                                    }
                                }
                                else if (frog_y == 2)
                                {
                                    if (road2[frog_x - 1] == '.')
                                    {
                                        road2[frog_x] = '.';
                                        frog_x = frog_x - 1;
                                    }
                                }
                                else if (frog_y == 1)
                                {
                                    if (road1[frog_x - 1] == '.')
                                    {
                                        road1[frog_x] = '.';
                                        frog_x = frog_x - 1;
                                    }
                                }
                                else if (frog_y == 0)
                                {
                                    if (border1[frog_x - 1] == '-')
                                    {
                                        border1[frog_x] = '-';
                                        frog_x = frog_x - 1;
                                    }
                                }

                                else
                                {
                                    if (border2[frog_x - 1] == '-')
                                    {
                                        border2[frog_x] = '-';
                                        frog_x = frog_x - 1;
                                    }
                                }
                                frog_direction = "Left";

                            }
                            break;
                        }
                        else if (movement.Key == ConsoleKey.UpArrow)
                        {
                            if (frog_y == -1)
                                frog_direction = "                    ";
                            else
                            {
                                frog_direction = "                    ";
                                if (frog_y == 5)
                                {
                                    if (road4[frog_x] == '.')
                                    {
                                        border2[frog_x] = '-';
                                        frog_y = frog_y - 1;
                                    }
                                    else
                                    {
                                        border2[frog_x] = '-';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }
                                }
                                else if (frog_y == 4)
                                    if (road3[frog_x] == '.')
                                    {
                                        road4[frog_x] = '.';
                                        frog_y = frog_y - 1;

                                    }
                                    else
                                    {
                                        road4[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }
                                else if (frog_y == 3)
                                    if (road2[frog_x] == '.')
                                    {
                                        road3[frog_x] = '.';
                                        frog_y = frog_y - 1;
                                    }
                                    else
                                    {
                                        road3[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;

                                    }
                                else if (frog_y == 2)
                                    if (road1[frog_x] == '.')
                                    {
                                        road2[frog_x] = '.';
                                        frog_y = frog_y - 1;
                                    }
                                    else
                                    {
                                        road2[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }

                                else if (frog_y == 1)
                                    if (border1[frog_x] == '-')
                                    {
                                        road1[frog_x] = '.';
                                        frog_y = frog_y - 1;
                                    }
                                    else
                                    {
                                        road1[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }

                                frog_direction = "Up";



                            }
                            break;
                        }

                        else if (movement.Key == ConsoleKey.DownArrow)
                        {
                            if (frog_y == 5)
                                frog_direction = "                    ";
                            else
                            {
                                frog_direction = "                    ";

                                if (frog_y == 4)
                                    if (border2[frog_x] == '-')
                                    {
                                        road4[frog_x] = '.';
                                        frog_y = frog_y + 1;
                                    }
                                    else
                                    {
                                        road4[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }
                                else if (frog_y == 3)
                                    if (road4[frog_x] == '.')
                                    {
                                        road3[frog_x] = '.';
                                        frog_y = frog_y + 1;
                                    }
                                    else
                                    {
                                        road3[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }
                                else if (frog_y == 2)
                                    if (road3[frog_x] == '.')
                                    {
                                        road2[frog_x] = '.';
                                        frog_y = frog_y + 1;
                                    }
                                    else
                                    {
                                        road2[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }

                                else if (frog_y == 1)
                                    if (road2[frog_x] == '.')
                                    {
                                        road1[frog_x] = '.';
                                        frog_y = frog_y + 1;
                                    }
                                    else
                                    {
                                        road1[frog_x] = '.';
                                        frog_x = 24;
                                        frog_y = 5;
                                        life = life - 1;
                                    }

                                frog_direction = "Down";
                            }

                            break;
                        }

                    }
                    if (frog_x > 49)    // Keeps the frog in roads.
                        frog_x = 49;
                    if (frog_x < 0)
                        frog_x = 0;
                    if (frog_y == 0)  //Writing the frog.
                    {

                        border1[frog_x] = 'F';

                    }
                    else if (frog_y == 1)
                    {

                        road1[frog_x] = 'F';

                    }
                    else if (frog_y == 2)
                    {

                        road2[frog_x] = 'F';

                    }
                    else if (frog_y == 3)
                    {

                        road3[frog_x] = 'F';

                    }
                    else if (frog_y == 4)
                    {

                        road4[frog_x] = 'F';

                    }
                    else if (frog_y == 5)
                    {

                        border2[frog_x] = 'F';

                    }
                    for (int i = 0; i < amount_of_vehicle2; i++) // Moving type 2 cars to the left.

                    {


                        if (left_vehicle2[i] == 1)// At the first road.
                        {
                            if (position_of_leftvehicle2[i] - 1 == 0) //End of the road control.
                            {
                                for (int j = 0; j < length_of_leftvehicle2[i]; j++) // Creating the road back.
                                {
                                    road1[position_of_leftvehicle2[i] + j] = '.';
                                }
                                randomizer = rnd.Next(2, 5);                           //New car spawn.
                                length_of_leftvehicle2[i] = randomizer;
                                position_of_leftvehicle2[i] = 45; //Puts new car to the start. 
                            }
                            if (position_of_leftvehicle2[i] != 0)
                            {
                                if (road1[position_of_leftvehicle2[i] - 1] == 'F') //Kills the frog.
                                {
                                    road1[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }
                                if (road1[position_of_leftvehicle2[i] - 2] != '1' && road1[position_of_leftvehicle2[i] - 2] != '2') //Car move controls.
                                {
                                    if ((length_of_leftvehicle2[i] == 2) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                    {
                                        road1[position_of_leftvehicle2[i]] = '.'; //Clears the car's back.
                                        road1[position_of_leftvehicle2[i] + 1] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;// Moves the car to the new point.
                                        road1[position_of_leftvehicle2[i]] = '2';// Writing the car at the new point.
                                        road1[position_of_leftvehicle2[i] + 1] = '2';

                                    }
                                    else if ((length_of_leftvehicle2[i] == 3) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                    {
                                        road1[position_of_leftvehicle2[i]] = '.';
                                        road1[position_of_leftvehicle2[i] + 1] = '.';
                                        road1[position_of_leftvehicle2[i] + 2] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road1[position_of_leftvehicle2[i]] = '2';
                                        road1[position_of_leftvehicle2[i] + 1] = '2';
                                        road1[position_of_leftvehicle2[i] + 2] = '2';

                                    }
                                    else if ((length_of_leftvehicle2[i] == 4) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                    {
                                        road1[position_of_leftvehicle2[i]] = '.';
                                        road1[position_of_leftvehicle2[i] + 1] = '.';
                                        road1[position_of_leftvehicle2[i] + 2] = '.';
                                        road1[position_of_leftvehicle2[i] + 3] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road1[position_of_leftvehicle2[i]] = '2';
                                        road1[position_of_leftvehicle2[i] + 1] = '2';
                                        road1[position_of_leftvehicle2[i] + 2] = '2';
                                        road1[position_of_leftvehicle2[i] + 3] = '2';


                                    }
                                }
                            }
                            else
                            {
                                if (time % 2 == 1) //Type2 car's decreasing speed when there is a type 1 car in front of it.
                                {
                                    if (position_of_leftvehicle2[i] != 0)
                                    {
                                        if (road1[position_of_leftvehicle2[i] - 1] == 'F') // Killing the car.
                                        {
                                            road1[frog_x] = '.';
                                            life = life - 1;
                                            frog_x = 24;
                                            frog_y = 5;
                                        }
                                        if ((length_of_leftvehicle2[i] == 2) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle2[i]] = '.';
                                            road1[position_of_leftvehicle2[i] + 1] = '.';
                                            position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                            road1[position_of_leftvehicle2[i]] = '2';
                                            road1[position_of_leftvehicle2[i] + 1] = '2';

                                        }
                                        else if ((length_of_leftvehicle2[i] == 3) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle2[i]] = '.';
                                            road1[position_of_leftvehicle2[i] + 1] = '.';
                                            road1[position_of_leftvehicle2[i] + 2] = '.';
                                            position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                            road1[position_of_leftvehicle2[i]] = '2';
                                            road1[position_of_leftvehicle2[i] + 1] = '2';
                                            road1[position_of_leftvehicle2[i] + 2] = '2';

                                        }
                                        else if ((length_of_leftvehicle2[i] == 4) && (road1[position_of_leftvehicle2[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle2[i]] = '.';
                                            road1[position_of_leftvehicle2[i] + 1] = '.';
                                            road1[position_of_leftvehicle2[i] + 2] = '.';
                                            road1[position_of_leftvehicle2[i] + 3] = '.';
                                            position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                            road1[position_of_leftvehicle2[i]] = '2';
                                            road1[position_of_leftvehicle2[i] + 1] = '2';
                                            road1[position_of_leftvehicle2[i] + 2] = '2';
                                            road1[position_of_leftvehicle2[i] + 3] = '2';


                                        }

                                    }
                                }

                            }
                        }


                        else if (left_vehicle2[i] == 2)// At the second road.
                        {
                            if (position_of_leftvehicle2[i] != 0)
                            {
                                if (road2[position_of_leftvehicle2[i] - 1] == 'F')
                                {
                                    road2[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }
                                if (position_of_leftvehicle2[i] - 1 == 0)
                                {
                                    for (int j = 0; j < length_of_leftvehicle2[i]; j++)
                                    {
                                        road2[position_of_leftvehicle2[i] + j] = '.';
                                    }
                                    randomizer = rnd.Next(2, 5);
                                    length_of_leftvehicle2[i] = randomizer;
                                    position_of_leftvehicle2[i] = 45;
                                }
                                if (road2[position_of_leftvehicle2[i] - 2] != '1' && road2[position_of_leftvehicle2[i] - 2] != '2')
                                {

                                    if ((length_of_leftvehicle2[i] == 2) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {

                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';

                                    }
                                    else if ((length_of_leftvehicle2[i] == 3) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {

                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        road2[position_of_leftvehicle2[i] + 2] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';
                                        road2[position_of_leftvehicle2[i] + 2] = '2';

                                    }
                                    else if ((length_of_leftvehicle2[i] == 4) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {
                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        road2[position_of_leftvehicle2[i] + 2] = '.';
                                        road2[position_of_leftvehicle2[i] + 3] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';
                                        road2[position_of_leftvehicle2[i] + 2] = '2';
                                        road2[position_of_leftvehicle2[i] + 3] = '2';


                                    }

                                }
                            }
                            else if (time % 2 == 1)
                            {

                                if (road2[position_of_leftvehicle2[i] - 1] == 'F')
                                {
                                    road2[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }
                                if (position_of_leftvehicle2[i] != 0)
                                {
                                    if ((length_of_leftvehicle2[i] == 2) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {

                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';

                                    }
                                    else if ((length_of_leftvehicle2[i] == 3) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {

                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        road2[position_of_leftvehicle2[i] + 2] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';
                                        road2[position_of_leftvehicle2[i] + 2] = '2';
                                    }
                                    else if ((length_of_leftvehicle2[i] == 4) && (road2[position_of_leftvehicle2[i] - 1] == '.'))
                                    {
                                        road2[position_of_leftvehicle2[i]] = '.';
                                        road2[position_of_leftvehicle2[i] + 1] = '.';
                                        road2[position_of_leftvehicle2[i] + 2] = '.';
                                        road2[position_of_leftvehicle2[i] + 3] = '.';
                                        position_of_leftvehicle2[i] = position_of_leftvehicle2[i] - 1;
                                        road2[position_of_leftvehicle2[i]] = '2';
                                        road2[position_of_leftvehicle2[i] + 1] = '2';
                                        road2[position_of_leftvehicle2[i] + 2] = '2';
                                        road2[position_of_leftvehicle2[i] + 3] = '2';

                                    }

                                }
                            }
                        }

                    }

                    if (time % 2 == 1)
                    {
                        for (int i = 0; i < amount_of_vehicle1; i++) // Moving type 1 cars to the left.
                        {


                            if (position_of_leftvehicle1[i] != 0)
                            {




                                if (left_vehicle1[i] == 1) //At the first road.
                                {
                                    if (road1[position_of_leftvehicle1[i] - 1] == 'F')
                                    {
                                        road1[frog_x] = '.';
                                        life = life - 1;
                                        frog_x = 24;
                                        frog_y = 5;
                                    }
                                    if (position_of_leftvehicle1[i] - 1 == 0)
                                    {
                                        for (int j = 0; j < length_of_leftvehicle1[i]; j++)
                                        {
                                            road1[position_of_leftvehicle1[i] + j] = '.';
                                        }
                                        randomizer = rnd.Next(2, 5);
                                        length_of_leftvehicle1[i] = randomizer;
                                        position_of_leftvehicle1[i] = 45;
                                    }
                                    if (road1[position_of_leftvehicle1[i] - 2] != '1' && road1[position_of_leftvehicle1[i] - 2] != '2')
                                    {
                                        if ((length_of_leftvehicle1[i] == 2) && (road1[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle1[i]] = '.';
                                            road1[position_of_leftvehicle1[i] + 1] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road1[position_of_leftvehicle1[i]] = '1';
                                            road1[position_of_leftvehicle1[i] + 1] = '1';
                                        }
                                        else if ((length_of_leftvehicle1[i] == 3) && (road1[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle1[i]] = '.';
                                            road1[position_of_leftvehicle1[i] + 1] = '.';
                                            road1[position_of_leftvehicle1[i] + 2] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road1[position_of_leftvehicle1[i]] = '1';
                                            road1[position_of_leftvehicle1[i] + 1] = '1';
                                            road1[position_of_leftvehicle1[i] + 2] = '1';
                                        }
                                        else if ((length_of_leftvehicle1[i] == 4) && (road1[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road1[position_of_leftvehicle1[i]] = '.';
                                            road1[position_of_leftvehicle1[i] + 1] = '.';
                                            road1[position_of_leftvehicle1[i] + 2] = '.';
                                            road1[position_of_leftvehicle1[i] + 3] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road1[position_of_leftvehicle1[i]] = '1';
                                            road1[position_of_leftvehicle1[i] + 1] = '1';
                                            road1[position_of_leftvehicle1[i] + 2] = '1';
                                            road1[position_of_leftvehicle1[i] + 3] = '1';
                                        }

                                    }
                                }
                            }



                            if (left_vehicle1[i] == 2)// At the second road.
                            {
                                if (road2[position_of_leftvehicle1[i] - 1] == 'F')
                                {
                                    road2[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }

                                if (position_of_leftvehicle1[i] - 1 == 0)
                                {

                                    for (int j = 0; j < length_of_leftvehicle1[i]; j++)
                                    {
                                        road2[position_of_leftvehicle1[i] + j] = '.';
                                    }
                                    randomizer = rnd.Next(2, 5);
                                    length_of_leftvehicle1[i] = randomizer;
                                    position_of_leftvehicle1[i] = 45;
                                }
                                if (position_of_leftvehicle1[i] != 0)
                                {


                                    if (road2[position_of_leftvehicle1[i] - 2] != '1' && road2[position_of_leftvehicle1[i] - 2] != '2')
                                    {
                                        if ((length_of_leftvehicle1[i] == 2) && (road2[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road2[position_of_leftvehicle1[i]] = '.';
                                            road2[position_of_leftvehicle1[i] + 1] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road2[position_of_leftvehicle1[i]] = '1';
                                            road2[position_of_leftvehicle1[i] + 1] = '1';
                                        }
                                        else if ((length_of_leftvehicle1[i] == 3) && (road2[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road2[position_of_leftvehicle1[i]] = '.';
                                            road2[position_of_leftvehicle1[i] + 1] = '.';
                                            road2[position_of_leftvehicle1[i] + 2] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road2[position_of_leftvehicle1[i]] = '1';
                                            road2[position_of_leftvehicle1[i] + 1] = '1';
                                            road2[position_of_leftvehicle1[i] + 2] = '1';
                                        }
                                        else if ((length_of_leftvehicle1[i] == 4) && (road2[position_of_leftvehicle1[i] - 1] == '.'))
                                        {
                                            road2[position_of_leftvehicle1[i]] = '.';
                                            road2[position_of_leftvehicle1[i] + 1] = '.';
                                            road2[position_of_leftvehicle1[i] + 2] = '.';
                                            road2[position_of_leftvehicle1[i] + 3] = '.';
                                            position_of_leftvehicle1[i] = position_of_leftvehicle1[i] - 1;
                                            road2[position_of_leftvehicle1[i]] = '1';
                                            road2[position_of_leftvehicle1[i] + 1] = '1';
                                            road2[position_of_leftvehicle1[i] + 2] = '1';
                                            road2[position_of_leftvehicle1[i] + 3] = '1';
                                        }




                                    }


                                }
                            }

                        }
                    }

                    for (int i = 0; i < amount_of_vehicle2; i++)// Moving type 2 cars to the right.
                    {


                        if (right_vehicle2[i] == 3)// For the third road.
                        {

                            if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] == 49)
                            {
                                for (int j = 0; j < length_of_rightvehicle2[i]; j++)
                                {
                                    road3[position_of_rightvehicle2[i] + j] = '.';
                                }
                                randomizer = rnd.Next(2, 5);
                                length_of_rightvehicle2[i] = randomizer;
                                position_of_rightvehicle2[i] = 0;
                            }
                            if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] != 49)
                            {

                                if (road3[position_of_rightvehicle2[i] + length_of_rightvehicle2[i]] == 'F')
                                {
                                    road3[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }
                                if (road3[position_of_rightvehicle2[i] + length_of_rightvehicle2[i] + 1] != '1' && road3[position_of_rightvehicle2[i] + length_of_rightvehicle2[i] + 1] != '2')
                                {
                                    if ((length_of_rightvehicle2[i] == 2) && (road3[position_of_rightvehicle2[i] + 2] == '.'))
                                    {
                                        road3[position_of_rightvehicle2[i]] = '.';
                                        road3[position_of_rightvehicle2[i] + 1] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road3[position_of_rightvehicle2[i]] = '2';
                                        road3[position_of_rightvehicle2[i] + 1] = '2';
                                    }
                                    else if ((length_of_rightvehicle2[i] == 3) && (road3[position_of_rightvehicle2[i] + 3] == '.'))
                                    {
                                        road3[position_of_rightvehicle2[i]] = '.';
                                        road3[position_of_rightvehicle2[i] + 1] = '.';
                                        road3[position_of_rightvehicle2[i] + 2] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road3[position_of_rightvehicle2[i]] = '2';
                                        road3[position_of_rightvehicle2[i] + 1] = '2';
                                        road3[position_of_rightvehicle2[i] + 2] = '2';
                                    }
                                    else if ((length_of_rightvehicle2[i] == 4) && (road3[position_of_rightvehicle2[i] + 4] == '.'))
                                    {
                                        road3[position_of_rightvehicle2[i]] = '.';
                                        road3[position_of_rightvehicle2[i] + 1] = '.';
                                        road3[position_of_rightvehicle2[i] + 2] = '.';
                                        road3[position_of_rightvehicle2[i] + 3] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road3[position_of_rightvehicle2[i]] = '2';
                                        road3[position_of_rightvehicle2[i] + 1] = '2';
                                        road3[position_of_rightvehicle2[i] + 2] = '2';
                                        road3[position_of_rightvehicle2[i] + 3] = '2';

                                    }
                                }

                            }

                            else
                            {
                                if (time % 2 == 1)
                                {
                                    if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] != 49)
                                    {
                                        if (road3[position_of_rightvehicle2[i] + length_of_rightvehicle2[i]] == 'F')
                                        {
                                            road3[frog_x] = '.';
                                            life = life - 1;
                                            frog_x = 24;
                                            frog_y = 5;
                                        }

                                        if ((length_of_rightvehicle2[i] == 2) && (road3[position_of_rightvehicle2[i] + 2] == '.'))
                                        {
                                            road3[position_of_rightvehicle2[i]] = '.';
                                            road3[position_of_rightvehicle2[i] + 1] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road3[position_of_rightvehicle2[i]] = '2';
                                            road3[position_of_rightvehicle2[i] + 1] = '2';
                                        }
                                        else if ((length_of_rightvehicle2[i] == 3) && (road3[position_of_rightvehicle2[i] + 3] == '.'))
                                        {
                                            road3[position_of_rightvehicle2[i]] = '.';
                                            road3[position_of_rightvehicle2[i] + 1] = '.';
                                            road3[position_of_rightvehicle2[i] + 2] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road3[position_of_rightvehicle2[i]] = '2';
                                            road3[position_of_rightvehicle2[i] + 1] = '2';
                                            road3[position_of_rightvehicle2[i] + 2] = '2';
                                        }
                                        else if ((length_of_rightvehicle2[i] == 4) && (road3[position_of_rightvehicle2[i] + 4] == '.'))
                                        {
                                            road3[position_of_rightvehicle2[i]] = '.';
                                            road3[position_of_rightvehicle2[i] + 1] = '.';
                                            road3[position_of_rightvehicle2[i] + 2] = '.';
                                            road3[position_of_rightvehicle2[i] + 3] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road3[position_of_rightvehicle2[i]] = '2';
                                            road3[position_of_rightvehicle2[i] + 1] = '2';
                                            road3[position_of_rightvehicle2[i] + 2] = '2';
                                            road3[position_of_rightvehicle2[i] + 3] = '2';

                                        }
                                    }
                                }
                            }

                        }



                        else if (right_vehicle2[i] == 4)// For the fourth road.
                        {
                            if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] == 49)
                            {
                                for (int j = 0; j < length_of_rightvehicle2[i]; j++)
                                {
                                    road4[position_of_rightvehicle2[i] + j] = '.';
                                }
                                randomizer = rnd.Next(2, 5);
                                length_of_rightvehicle2[i] = randomizer;
                                position_of_rightvehicle2[i] = 0;
                            }
                            if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] != 49)
                            {
                                if (road4[position_of_rightvehicle2[i] + length_of_rightvehicle2[i]] == 'F')
                                {
                                    road4[frog_x] = '.';
                                    life = life - 1;
                                    frog_x = 24;
                                    frog_y = 5;
                                }

                                if (road4[position_of_rightvehicle2[i] + length_of_rightvehicle2[i] + 1] != '1' && road4[position_of_rightvehicle2[i] + length_of_rightvehicle2[i] + 1] != '2')
                                {
                                    if ((length_of_rightvehicle2[i] == 2) && (road4[position_of_rightvehicle2[i] + 2] == '.'))
                                    {

                                        road4[position_of_rightvehicle2[i]] = '.';
                                        road4[position_of_rightvehicle2[i] + 1] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road4[position_of_rightvehicle2[i]] = '2';
                                        road4[position_of_rightvehicle2[i] + 1] = '2';
                                    }
                                    else if ((length_of_rightvehicle2[i] == 3) && (road4[position_of_rightvehicle2[i] + 3] == '.'))
                                    {

                                        road4[position_of_rightvehicle2[i]] = '.';
                                        road4[position_of_rightvehicle2[i] + 1] = '.';
                                        road4[position_of_rightvehicle2[i] + 2] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road4[position_of_rightvehicle2[i]] = '2';
                                        road4[position_of_rightvehicle2[i] + 1] = '2';
                                        road4[position_of_rightvehicle2[i] + 2] = '2';
                                    }
                                    else if ((length_of_rightvehicle2[i] == 4) && (road4[position_of_rightvehicle2[i] + 4] == '.'))
                                    {
                                        road4[position_of_rightvehicle2[i]] = '.';
                                        road4[position_of_rightvehicle2[i] + 1] = '.';
                                        road4[position_of_rightvehicle2[i] + 2] = '.';
                                        road4[position_of_rightvehicle2[i] + 3] = '.';
                                        position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                        road4[position_of_rightvehicle2[i]] = '2';
                                        road4[position_of_rightvehicle2[i] + 1] = '2';
                                        road4[position_of_rightvehicle2[i] + 2] = '2';
                                        road4[position_of_rightvehicle2[i] + 3] = '2';

                                    }

                                }
                            }
                            else
                            {
                                if (time % 2 == 1)
                                {
                                    if (position_of_rightvehicle2[i] + length_of_rightvehicle2[i] != 49)
                                    {
                                        if (road4[position_of_rightvehicle2[i] + length_of_rightvehicle2[i]] == 'F')
                                        {
                                            road4[frog_x] = '.';
                                            life = life - 1;
                                            frog_x = 24;
                                            frog_y = 5;
                                        }
                                        if ((length_of_rightvehicle2[i] == 2) && (road4[position_of_rightvehicle2[i] + 2] == '.') && road4[position_of_rightvehicle1[i] + 3] != '2')
                                        {

                                            road4[position_of_rightvehicle2[i]] = '.';
                                            road4[position_of_rightvehicle2[i] + 1] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road4[position_of_rightvehicle2[i]] = '2';
                                            road4[position_of_rightvehicle2[i] + 1] = '2';
                                        }
                                        else if ((length_of_rightvehicle2[i] == 3) && (road4[position_of_rightvehicle2[i] + 3] == '.') && road4[position_of_rightvehicle1[i] + 4] != '2')
                                        {

                                            road4[position_of_rightvehicle2[i]] = '.';
                                            road4[position_of_rightvehicle2[i] + 1] = '.';
                                            road4[position_of_rightvehicle2[i] + 2] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road4[position_of_rightvehicle2[i]] = '2';
                                            road4[position_of_rightvehicle2[i] + 1] = '2';
                                            road4[position_of_rightvehicle2[i] + 2] = '2';
                                        }
                                        else if ((length_of_rightvehicle2[i] == 4) && (road4[position_of_rightvehicle2[i] + 4] == '.') && road4[position_of_rightvehicle2[i] + 5] != '2')
                                        {
                                            road4[position_of_rightvehicle2[i]] = '.';
                                            road4[position_of_rightvehicle2[i] + 1] = '.';
                                            road4[position_of_rightvehicle2[i] + 2] = '.';
                                            road4[position_of_rightvehicle2[i] + 3] = '.';
                                            position_of_rightvehicle2[i] = position_of_rightvehicle2[i] + 1;
                                            road4[position_of_rightvehicle2[i]] = '2';
                                            road4[position_of_rightvehicle2[i] + 1] = '2';
                                            road4[position_of_rightvehicle2[i] + 2] = '2';
                                            road4[position_of_rightvehicle2[i] + 3] = '2';

                                        }

                                    }
                                }


                            }
                        }

                    }
                    if (time % 2 == 1)
                    {
                        for (int i = 0; i < amount_of_vehicle1; i++) // Moving type 1 cars to the right.

                        {


                            if (right_vehicle1[i] == 4)//Writes the road back.
                            {
                                if (position_of_rightvehicle1[i] + length_of_rightvehicle1[i] == 49)
                                {
                                    for (int j = 0; j < length_of_rightvehicle1[i]; j++)
                                    {
                                        road4[position_of_rightvehicle1[i] + j] = '.';
                                    }
                                    randomizer = rnd.Next(2, 5);
                                    length_of_rightvehicle1[i] = randomizer;
                                    position_of_rightvehicle1[i] = 0;
                                }
                            }


                            if (position_of_rightvehicle1[i] + length_of_rightvehicle1[i] != 49)
                            {
                                if (right_vehicle1[i] == 3)//Moves the car and delets it at the third road.
                                {
                                    if (position_of_rightvehicle1[i] + length_of_rightvehicle1[i] == 48)
                                    {
                                        for (int j = 0; j < length_of_rightvehicle1[i]; j++)
                                        {
                                            road3[position_of_rightvehicle1[i] + j] = '.';
                                        }
                                        randomizer = rnd.Next(2, 5);
                                        length_of_rightvehicle1[i] = randomizer;
                                        position_of_rightvehicle1[i] = 0;
                                    }
                                    if (road3[position_of_rightvehicle1[i] + length_of_rightvehicle1[i]] == 'F')
                                    {
                                        road3[frog_x] = '.';
                                        life = life - 1;
                                        frog_x = 24;
                                        frog_y = 5;
                                    }

                                    if ((length_of_rightvehicle1[i] == 2) && (road3[position_of_rightvehicle1[i] + 2] == '.') && road3[position_of_rightvehicle1[i] + 3] != '1' && road3[position_of_rightvehicle1[i] + 3] != '2')
                                    {
                                        road3[position_of_rightvehicle1[i]] = '.';
                                        road3[position_of_rightvehicle1[i] + 1] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road3[position_of_rightvehicle1[i]] = '1';
                                        road3[position_of_rightvehicle1[i] + 1] = '1';
                                    }
                                    if ((length_of_rightvehicle1[i] == 3) && (road3[position_of_rightvehicle1[i] + 3] == '.') && road3[position_of_rightvehicle1[i] + 4] != '1' && road3[position_of_rightvehicle1[i] + 4] != '2')
                                    {
                                        road3[position_of_rightvehicle1[i]] = '.';
                                        road3[position_of_rightvehicle1[i] + 1] = '.';
                                        road3[position_of_rightvehicle1[i] + 2] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road3[position_of_rightvehicle1[i]] = '1';
                                        road3[position_of_rightvehicle1[i] + 1] = '1';
                                        road3[position_of_rightvehicle1[i] + 2] = '1';
                                    }
                                    else if ((length_of_rightvehicle1[i] == 4) && (road3[position_of_rightvehicle1[i] + 4] == '.') && road3[position_of_rightvehicle1[i] + 5] != '1' && road3[position_of_rightvehicle1[i] + 5] != '2')
                                    {
                                        road3[position_of_rightvehicle1[i]] = '.';
                                        road3[position_of_rightvehicle1[i] + 1] = '.';
                                        road3[position_of_rightvehicle1[i] + 2] = '.';
                                        road3[position_of_rightvehicle1[i] + 3] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road3[position_of_rightvehicle1[i]] = '1';
                                        road3[position_of_rightvehicle1[i] + 1] = '1';
                                        road3[position_of_rightvehicle1[i] + 2] = '1';
                                        road3[position_of_rightvehicle1[i] + 3] = '1';
                                    }

                                }



                                if (right_vehicle1[i] == 4)// Moving the cars at the fourth road.
                                {

                                    if (road4[position_of_rightvehicle1[i] + length_of_rightvehicle1[i]] == 'F')// Kills the frog.
                                    {
                                        road4[frog_x] = '.';
                                        life = life - 1;
                                        frog_x = 24;
                                        frog_y = 5;
                                    }


                                    if ((length_of_rightvehicle1[i] == 2) && (road4[position_of_rightvehicle1[i] + 2] == '.') && road4[position_of_rightvehicle1[i] + 3] != '1' && road4[position_of_rightvehicle1[i] + 3] != '2')
                                    {
                                        road4[position_of_rightvehicle1[i]] = '.';
                                        road4[position_of_rightvehicle1[i] + 1] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road4[position_of_rightvehicle1[i]] = '1';
                                        road4[position_of_rightvehicle1[i] + 1] = '1';
                                    }
                                    else if ((length_of_rightvehicle1[i] == 3) && (road4[position_of_rightvehicle1[i] + 3] == '.') && road4[position_of_rightvehicle1[i] + 4] != '1' && road4[position_of_rightvehicle1[i] + 4] != '2')
                                    {
                                        road4[position_of_rightvehicle1[i]] = '.';
                                        road4[position_of_rightvehicle1[i] + 1] = '.';
                                        road4[position_of_rightvehicle1[i] + 2] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road4[position_of_rightvehicle1[i]] = '1';
                                        road4[position_of_rightvehicle1[i] + 1] = '1';
                                        road4[position_of_rightvehicle1[i] + 2] = '1';
                                    }
                                    else if ((length_of_rightvehicle1[i] == 4) && (road4[position_of_rightvehicle1[i] + 4] == '.') && road4[position_of_rightvehicle1[i] + 5] != '1' && road4[position_of_rightvehicle1[i] + 5] != '2')
                                    {
                                        road4[position_of_rightvehicle1[i]] = '.';
                                        road4[position_of_rightvehicle1[i] + 1] = '.';
                                        road4[position_of_rightvehicle1[i] + 2] = '.';
                                        road4[position_of_rightvehicle1[i] + 3] = '.';
                                        position_of_rightvehicle1[i] = position_of_rightvehicle1[i] + 1;
                                        road4[position_of_rightvehicle1[i]] = '1';
                                        road4[position_of_rightvehicle1[i] + 1] = '1';
                                        road4[position_of_rightvehicle1[i] + 2] = '1';
                                        road4[position_of_rightvehicle1[i] + 3] = '1';

                                    }




                                }
                            }



                        }
                    }






                    if (frog_y == 0) // Level up.
                    {
                        Console.Clear();
                        level = level + 1;
                        frog_x = 24;
                        frog_y = 5;
                        amount_of_vehicle1 = amount_of_vehicle1 - 2;
                        amount_of_vehicle2 = amount_of_vehicle2 + 2;
                        score = score + 60 - time;
                        time = 0;
                        life = life + 1;
                        car_placement_counter = 0;
                        level_score = 60 - time;
                        if (score < 0)
                            score = 0;
                        right_controller2 = new int[amount_of_vehicle2];
                        right_controller1 = new int[amount_of_vehicle1];
                        left_controller2 = new int[amount_of_vehicle2];
                        left_controller1 = new int[amount_of_vehicle1];
                        position_of_rightvehicle2 = new int[amount_of_vehicle2];
                        length_of_rightvehicle2 = new int[amount_of_vehicle2];
                        position_of_leftvehicle2 = new int[amount_of_vehicle2];
                        length_of_leftvehicle2 = new int[amount_of_vehicle2];
                        position_of_rightvehicle1 = new int[amount_of_vehicle1];
                        length_of_rightvehicle1 = new int[amount_of_vehicle1];
                        position_of_leftvehicle1 = new int[amount_of_vehicle1];
                        length_of_leftvehicle1 = new int[amount_of_vehicle1];
                        right_vehicle2 = new int[amount_of_vehicle2];
                        left_vehicle2 = new int[amount_of_vehicle2];
                        left_vehicle1 = new int[amount_of_vehicle1];
                        right_vehicle1 = new int[amount_of_vehicle1];
                        for (int i = 0; i < border1.Length; i++)
                        {
                            border1[i] = '-';
                        }
                        for (int i = 0; i < border2.Length; i++)
                        {
                            border2[i] = '-';
                        }
                        for (int i = 0; i < road1.Length; i++)
                        {
                            road1[i] = '.';
                        }
                        for (int i = 0; i < road2.Length; i++)
                        {
                            road2[i] = '.';
                        }
                        for (int i = 0; i < road3.Length; i++)
                        {
                            road3[i] = '.';
                        }
                        for (int i = 0; i < road4.Length; i++)
                        {
                            road4[i] = '.';
                        }
                        Console.SetCursorPosition(60, 2);
                        Console.Write("YOU GET 1 LIFE !");
                        Console.SetCursorPosition(60, 3);
                        Console.Write("SCORE IS UPDATED BY ADDING " + level_score + " POINTS !");



                    }
                    if (life == 0)  // End of the game.
                    {
                        game = false;
                        if (frog_y == 0)
                        {

                            border1[frog_x] = 'F';

                        }
                        else if (frog_y == 1)
                        {

                            road1[frog_x] = 'F';

                        }
                        else if (frog_y == 2)
                        {

                            road2[frog_x] = 'F';

                        }
                        else if (frog_y == 3)
                        {

                            road3[frog_x] = 'F';

                        }
                        else if (frog_y == 4)
                        {

                            road4[frog_x] = 'F';

                        }
                        else if (frog_y == 5)
                        {

                            border2[frog_x] = 'F';

                        }
                        Console.SetCursorPosition(0, 0);
                        for (int i = 0; i < border1.Length; i++)
                        {
                            Console.Write(border1[i]);
                        }
                        Console.WriteLine();
                        for (int i = 0; i <= road1.Length; i++)
                        {
                            if (i != 50)
                                Console.Write(road1[i]);
                            if (i == 50)
                                Console.Write("<<");
                        }
                        Console.WriteLine();
                        for (int i = 0; i <= road2.Length; i++)
                        {
                            if (i != 50)
                                Console.Write(road2[i]);
                            if (i == 50)
                                Console.Write("<<");
                        }
                        Console.WriteLine();
                        for (int i = 0; i <= road3.Length; i++)
                        {
                            if (i != 50)
                                Console.Write(road3[i]);
                            if (i == 50)
                                Console.Write(">>");
                        }
                        Console.WriteLine();
                        for (int i = 0; i <= road4.Length; i++)
                        {
                            if (i != 50)
                                Console.Write(road4[i]);
                            if (i == 50)
                                Console.Write(">>");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < border2.Length; i++)
                        {
                            Console.Write(border2[i]);
                        }
                        Console.SetCursorPosition(5, 6);
                        Console.Write("Time: " + time);
                        Console.SetCursorPosition(5, 7);
                        Console.Write("Level: " + level);
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Frog direction: " + frog_direction);
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Score: " + score);
                        Console.SetCursorPosition(5, 10);
                        Console.Write("Life: " + life);
                        Console.WriteLine("");
                        Console.WriteLine("             GAME OVER      ");
                        Console.WriteLine("Press any key  to exit ");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    System.Threading.Thread.Sleep(500);
                    time = time + 1;
                }


            }
        }
    }
}