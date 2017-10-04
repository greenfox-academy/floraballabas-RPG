﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Skeleton : Enemy
    {
        private static int startingX = 50;
        private static int startingY = 50;
        private static int boardsize = 50;
        static Random rnd = new Random();

        public Skeleton()
        {
            int x = 1;
            this.currentHP = maxHP;
            this.maxHP = 2 * x * RollDice();
            this.DP = 2 * x/2 * RollDice();
            this.SP = 5 * x * RollDice();
        }
        public static void PlaceEnemy(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/skeleton.png", startingX * rnd.Next(1, 11), startingY * rnd.Next(1, 11));
            foxDraw.AddImage("./Assets/skeleton.png", startingX * rnd.Next(1, 11), startingY * rnd.Next(1, 11));
            foxDraw.AddImage("./Assets/skeleton.png", startingX * rnd.Next(1, 11), startingY * rnd.Next(1, 11));
        }
    }
}