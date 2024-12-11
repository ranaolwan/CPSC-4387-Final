using UnityEngine;

public class Trap : MonoBehaviour
{
    public int penalty = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().DeductScore(penalty);
        }
    }
}
