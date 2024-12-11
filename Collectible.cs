using UnityEngine;
using Photon.Pun;

public class Collectible : MonoBehaviourPun
{
    public int points = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && photonView.IsMine)
        {
            GameManager.Instance.AddScore(points); // Add score to local player
            PhotonNetwork.Destroy(gameObject); // Destroy the collectible for all clients
        }
    }
}
