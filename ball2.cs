using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkBallController : NetworkBehaviour
{
    public float speed = 10f; // Movement speed of the ball
    private Rigidbody rb;     // Reference to the Rigidbody component of the ball

    private void Awake()
    {
        // Get the Rigidbody component attached to this ball
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Only the owner can control the ball
        if (!IsOwner) return;

        // Get input for movement (Z, A, and S keys)
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.A)) // Move left
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D)) // Move right
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            moveZ = 1f;
        }
        if (Input.GetKey(KeyCode.S)) // Move backward
        {
            moveZ = -1f;
        }

        // Apply movement to the Rigidbody
        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
