using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture22
{
    // i think the benefit of delegates is decoupling 
    // this class is the mediator between Player and UIDisplay
    public class GameManager : MonoBehaviour
    {
        Player player;
        UIDisplay uIDisplay;
        // why we but all the statements in the OnEnable()??
        // because its invoked before the Start and the handle will invoked before 
        //the objects and thats not true
        void OnEnable()
        {
            player = new Player();
            uIDisplay = new UIDisplay();
            // now after it finished it stays in the memory 
            // so we need to unsubscripe using OnDisable
            player.handleScoreChanged += uIDisplay.DisplayScoreUI;// Subscription
        }
        void Start()
        {
            //this is bad because it modify the score like hackers
            // so how we can protects the dada from being tampered
            // بدنا نمنعه من انه يتنادى خارج الكلاس الي تعرف فيه المتغير تبعه
            // player.handleScoreChanged?.Invoke(1_000_000);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                player.ChangeScore(1);
            }
        }
    }
    public delegate void HandleScoreChanged(int i);
    // this class is the notifier when the score increase give a notice(using the invokation
    // of handleScoreChanged)and says to the observer(UIDisplay) that the score increased
    public class Player
    {
        public int score = 0;
        // event keyword not in the definition of the delegate but in the declaration of it
        //player class فقط الاستدعاء بكون داخل event الان هاي
        // and subscripe & unsubscripe(+= , -=) outside player class and (=) is not allowed only(+= , -=) 
        //because (=) erased the previous
        // so when we try to invoke it inside GameManager class gives us a compile error
        public event HandleScoreChanged handleScoreChanged;
        public void ChangeScore(int amount)
        {
            score += amount;
            // invoke the method like this is bad 
            // becouse it could return null and cause an exception
            // handleScoreChanged();
            // this is better becouse it check if its return null 
            // if does not store a method
            handleScoreChanged?.Invoke(score);
        }
    }
    // there is no relation between Player and UIDisplay
    // this is the observer class
    public class UIDisplay
    {
        // expression-bodied definition (=>) we can use it if the body of the method is one line
        public void DisplayScoreUI(int score) => Debug.Log("The score of the player is : " + score);

    }
}