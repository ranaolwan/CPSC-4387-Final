using UnityEngine;
using Photon.Pun;

public class MovingWall : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Vector3 startPoint;
    public Vector3 endPoint;
    private bool movingToEnd = true;

    void Start()
    {
        transform.position = startPoint;
    }

    void Update()
    {
        if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint, moveSpeed * Time.deltaTime);
            if (transform.position == endPoint)
                movingToEnd = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint, moveSpeed * Time.deltaTime);
            if (transform.position == startPoint)
                movingToEnd = true;
        }
    }
}
