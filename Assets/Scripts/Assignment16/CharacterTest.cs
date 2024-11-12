using System.Collections;
using System.Collections.Generic;
using Assignment14;
using Assignment16;
using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = { new Soldier(), new Officer("Max", 80, new Position(1, 20, 3)) };
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
            Debug.Log("Soldier`s health before attack: " + characters[0].Health);
            characters[1].Attack(20, characters[0], "punching");
            Debug.Log("Soldier`s health after attack: " + characters[0].Health);
        }
    }
}
