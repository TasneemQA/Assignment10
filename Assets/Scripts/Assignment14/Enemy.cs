using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name, int health) :
            base(name, health)
        { }
        public void Attack(int amount, Character target)
        {
            target.Health -= amount;
            Debug.Log(Name + " attacked " + target.Name + " for " + amount + " damage " + target.Name + "`s Health: " + target.Health);
        }
    }
}