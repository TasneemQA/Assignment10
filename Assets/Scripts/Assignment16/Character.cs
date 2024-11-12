using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get{return health;}
            set{health = Mathf.Clamp(value, 0, 100);}
        }
        public Character(string name, int health, Position position){
            this.name = name;
            Health = health;
            this.position = position;
        }
        public Character():this("No name", 100, new Assignment16.Position(0,0,0)){}
        public virtual void DisplayInfo(){
            Debug.Log("Name: " + name + ", Health: " + Health);
            position.printPosition();
        }
        public void Attack(int amount, Character target){
            target.Health -= amount;
        }

        public void Attack(int amount, Character target, string attackType){
            Debug.Log("Attack type: " + attackType);
            Attack(amount, target);
        }
    }
}
