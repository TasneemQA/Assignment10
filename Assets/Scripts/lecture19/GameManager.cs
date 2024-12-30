using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture19
{
    public class GameManager : MonoBehaviour
    {
        float executeTime = 1;
        bool isDead = false;

        public Player player;
        public Tasneem tasneem;
        void Start()
        {
            player = new Player();
            tasneem = new Tasneem();
            player.onHealthLoosed += GameOver;//subscription
            player.onHealthLoosed += tasneem.TasneemMethod;
        }
        void Update()
        {
            if ((Time.time > executeTime) && !isDead)
            {
                player.TakeDamage(500);
                isDead = true;
            }
        }
        void GameOver()
        {
            Debug.Log("Game Over!=(");
        }
    }
}