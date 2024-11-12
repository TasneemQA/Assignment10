using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
   public class GameManager : MonoBehaviour
   {
      void Start()
      {
         Player player = new Player("Subhi", 100);
         Enemy enemy = new Enemy("Zarifeh", 100);
         Debug.Log("Player: " + player.Name + ", Health: " + player.Health);
         Debug.Log("Enemy: " + enemy.Name + ", Health: " + enemy.Health);
         player.Heal(10);
         enemy.Attack(20, player);
         Debug.Log("After attack - Player health: " + player.Health + ", Enemy health: " + enemy.Health);
      }
   }
}