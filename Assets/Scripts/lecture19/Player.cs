using System;
using System.Collections;
using System.Collections.Generic;
using Assignment13;
using UnityEngine;
namespace lecture19
{
    public class Player
    {
        int health = 100;
        int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }
        public GameStages onHealthLoosed;
        public void TakeDamage(int amountOfDamage)
        {
            Health -= amountOfDamage;
            if (Health == 0)
            {
                onHealthLoosed?.Invoke();
            }
        }
    }
}