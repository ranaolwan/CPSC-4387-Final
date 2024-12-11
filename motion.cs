using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Motion : NetworkBehaviour
{
    public float speed = 10f;  // Movement speed of the ball
    private Rigidbody rb;      // Reference to the Rigidbody component of the ball

    // Movement keys for each ball
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode moveLeftKey;
    public KeyCode moveRightKey;

    private void Awake()
    {
        // Get the Rigidbody component attached to this ball
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Handle movement based on key presses
        float moveX = 0f;
        float moveZ = 0f;

        // Move left or right
        if (Input.GetKey(moveLeftKey))
        {
            moveX = -1f;
        }
        if (Input.GetKey(moveRightKey))
        {
            moveX = 1f;
        }

        // Move forward or backward
        if (Input.GetKey(moveForwardKey))
        {
            moveZ = 1f;
        }
        if (Input.GetKey(moveBackwardKey))
        {
            moveZ = -1f;
        }

        // Apply movement to the Rigidbody
        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
