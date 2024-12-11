using Unity.Netcode;
using UnityEngine;

public class ExitTrigger : NetworkBehaviour
{
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (IsServer) // Only the server can handle this event
            {
                // Handle game logic, such as notifying the winner or resetting the game
                Debug.Log($"{other.name} reached the exit!");
            }
        }
    }
}
