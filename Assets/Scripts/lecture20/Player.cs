using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
namespace lecture20
{
    public class Player
    {
        public string Name { get; set; }
        string[] Amlak = new string[1_000_000];
        private int _health;
        public int Health
        {
            get { return _health; }
            set { _health = Mathf.Clamp(value, 0, 100); }
        }
        public Player(string name, int health)
        {
            this.Name = name;
            this.Health = _health;
        }
        public Player(string name) : this(name, 100) { }
        public Player() : this("No Name", 100) { }
        ~Player() { } // invoked by garbage collecter amlak = null

    }
}