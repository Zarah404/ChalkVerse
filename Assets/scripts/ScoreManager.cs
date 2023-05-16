using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    // Increase the player's score by the specified amount
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    // Reset the player's score to zero
    public static void ResetScore()
    {
        score = 0;
    }
}
