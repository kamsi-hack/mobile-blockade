using UnityEngine;

public class OpenWorldManager : MonoBehaviour
{
    public Transform player;
    public GameObject[] terrainChunks;

    void Update()
    {
        foreach (GameObject chunk in terrainChunks)
        {
            float dist = Vector3.Distance(player.position, chunk.transform.position);
            chunk.SetActive(dist < 300f);
        }
    }
}
