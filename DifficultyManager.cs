using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public MovingWall[] walls;

    void Update()
    {
        foreach (var wall in walls)
        {
            wall.moveSpeed += Time.deltaTime * 0.1f; // Gradually increase speed
        }
    }
}
