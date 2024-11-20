using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    public class Character
    {
        private int health;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
    }
}