using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name = "Zarifeh";
    int health = 100;
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
