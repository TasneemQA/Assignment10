using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> game = new GameContainer<string>();
            game.SetItem("Healing Potion");
            Debug.Log("Stored item: " + game.GetItem());
            Debug.Log(GameUtils.DescribeItem<string>(game.GetItem()));
        }
    }
}
