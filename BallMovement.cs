using Photon.Pun; // Import Photon namespace for networking
using UnityEngine;

public class BallMovement : MonoBehaviourPunCallbacks
{
    public float speed = 5f; // Speed at which the ball moves

    private void Update()
    {
        // Only allow movement for the player who owns this object
        if (!photonView.IsMine) return; // Only the owner controls this ball

        // Get input for movement (WASD or arrow keys)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;

        // Apply movement
        transform.Translate(movement);

        // Optionally add logic for other behaviors, such as ball collision or rotation
    }
}
