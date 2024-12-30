using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        public class Animal
        {
            public virtual void MakeSound() => Debug.Log("Animal sound");
            public void Move() => Debug.Log("Animal moves");
        }
        public class Cat : Animal, ICanFight
        {
            public override void MakeSound() => Debug.Log("Meow!");
            public void Move() => Debug.Log("Cat runs quickly.");
            public void Attack()
            {
                Debug.Log("Cat attacks with claws");
            }
        }
        public interface ICanFight
        {
            public void Attack();
        }
        public class Warrior : ICanFight
        {
            public void Attack()
            {
                Debug.Log("Warrior attacks with a sword!");
            }
        }
        void Start()
        {

            Cat cat = new Cat();
            Animal animal = cat;//Upcasting
            animal.MakeSound();
            animal.Move();

            Cat cat1 = animal as Cat;//Downcasting
            cat1.MakeSound();
            cat1.Move();

            Warrior warrior = new Warrior();
            Cat cat2 = new Cat();
            List<ICanFight> canFights = new List<ICanFight>();
            canFights.Add(cat2);
            canFights.Add(warrior);
            foreach (ICanFight canFight in canFights)
            {
                if (canFight is Cat)
                {
                    Debug.Log("The obect is a Cat");
                }
                else if (canFight is Warrior)
                {
                    Debug.Log("The object is Warrior");
                }
                canFight.Attack();
            }

        }

    }
}