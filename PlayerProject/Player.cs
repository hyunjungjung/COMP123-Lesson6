﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class Player : GameObject, IShootable, ITouchable
    {
        private int _score;

        public Player(string name) : base(name)
        {
            
        }

        public int Score
        {
            get
            {
                return this._score;
            }

            set
            {
                this._score = value;
            }
        }

        public void Shoot()
        {
            Console.WriteLine("{0} is shooting", this.Name);
        }

        public void Fight()
        {
            Console.WriteLine("{0} is fighting", this.Name);
        }
    }
}