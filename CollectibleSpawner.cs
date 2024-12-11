using UnityEngine;
using Photon.Pun;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public Vector3[] spawnPoints;

    void Start()
    {
        if (PhotonNetwork.IsMasterClient) // Only the host spawns the collectibles
        {
            foreach (var spawnPoint in spawnPoints)
            {
                PhotonNetwork.Instantiate(collectiblePrefab.name, spawnPoint, Quaternion.identity);
            }
        }
    }
}
