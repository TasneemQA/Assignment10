using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player11 : Character
{
    public Player11(string name, int health):
        base(name, health){}
    public void Heal(int amount){
        Health += amount;
        Debug.Log(Health);
    }
}
