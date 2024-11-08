using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy11 : Character
{
    public Enemy11(string name, int health):
        base(name, health){}
    public void Attack(int amount, Character target){
        target.Health -= amount;
        Debug.Log(Health);
        Debug.Log(Health);
    }
}
