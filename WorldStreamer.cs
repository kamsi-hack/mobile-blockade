using UnityEngine;

public class WorldStreamer : MonoBehaviour
{
    public Transform player;
    public GameObject[] chunks;

    void Update()
    {
        foreach (GameObject chunk in chunks)
        {
            float dist = Vector3.Distance(player.position, chunk.transform.position);

            chunk.SetActive(dist < 200f);
        }
    }
}
