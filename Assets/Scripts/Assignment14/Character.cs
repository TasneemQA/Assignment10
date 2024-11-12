using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
<<<<<<< HEAD
    public class Character
=======
    private string name;
    int health;
    public string Name
>>>>>>> 1a08c3b2897adb76d70c15c424e5218f1b9c80d8
    {
        private string name;
        private int health;
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