using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void DeductScore(int amount)
    {
        score -= amount;
        if (score < 0) score = 0; // Prevent negative scores
        Debug.Log("Score: " + score);
    }
}
