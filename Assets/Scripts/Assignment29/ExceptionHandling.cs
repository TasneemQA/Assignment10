using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// 1. Set up a Score Calculation Scenario:
// ○ Declare two int variables:
// ■ playerScore = 100.
// ■ diviser = 0 (intentionally set to 0 to simulate division by zero).
// 2. Add a Try-Catch-Finally Block:
// ○ Try Block:
// ■ Attempt to calculate the player's total score by dividing playerScore by
// diviser.
// ■ Use the formula: int totalScore = playerScore / diviser;
// ■ Log "Attempting to calculate score multiplier...".
// ○ Catch Block:
// ■ Catch the DivideByZeroException.
// ■ Log an error message: "Error: Division by zero occurred
// while calculating score multiplier.".
// ○ Finally Block:
// ■ Log "Score calculation complete. Cleaning up
// resources.".
// Expected Unity Console Output
// Attempting to calculate score multiplier...
// Error: Division by zero occurred while calculating score multiplier.
// Score calculation complete. Cleaning up resources.
public class ExceptionHandling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerScore = 100;
        int diviser = 0;
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch (DivideByZeroException e)
        {
            Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
