using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();
        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void ShowItems()
        {
            foreach (string n in items)
            {
                Debug.Log(n);
            }
        }

        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory combined = new Inventory();
            combined.items.AddRange(a.items);
            combined.items.AddRange(b.items);
            return combined;
        }
    }
}
