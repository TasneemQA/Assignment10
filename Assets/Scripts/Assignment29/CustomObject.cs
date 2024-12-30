using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public CustomObject(int ID, string name)
        {
            this.ID = ID;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Object [ID: " + ID + " , Name:  " + Name + "]";
        }
        // public override bool Equals(object obj)
        // {
        //     if(obj is CustomObject other){
        //         return (ID == other.ID) && (Name == other.Name); 
        //     }
        //     return false;
        // }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (obj1.Name.Equals(obj2.Name) && obj1.ID.Equals(obj2.ID)) return true;
            }
            return false;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (!obj1.Name.Equals(obj2.Name) && !obj1.ID.Equals(obj2.ID)) return true;
            }
            return false;
        }
    }
}

