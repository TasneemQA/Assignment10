using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A Creature makes a sound");
        }
    }

    public interface IRunnable
    {
        public void Run();
    }
    public interface IJumpable
    {
        public void Jump();
    }
    public interface ISwimmable
    {
        public void Swim();
    }
}