using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour{
   void Start(){
      Player11 player = new Player11("Subhi" , 100);
      Enemy11 enemy = new Enemy11("Zarifeh", 100);
      Debug.Log(player.Name);
      Debug.Log(enemy.Name);
      player.Heal(10);
      enemy.Attack(20, player);
      Debug.Log(player.Health);
      Debug.Log(enemy.Health);
   }
}