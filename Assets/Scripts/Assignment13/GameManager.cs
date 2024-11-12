using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment13
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player player1 = new Player();
            Player player2 = new Player();

            player1.InitializePlayer("Tasneem", 20);
            player1.InitializePlayer("Yousef", 50);

            player1.Heal(20);
            player2.Heal(true);

            Player.ShowPlayerCount();
        }
    }
}