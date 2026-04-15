using UnityEngine;

public class BattleRoyaleManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject playerPrefab;

    public float zoneRadius = 200f;
    public float shrinkSpeed = 2f;

    void Start()
    {
        SpawnPlayers();
        InvokeRepeating("ShrinkZone", 10f, 5f);
    }

    void SpawnPlayers()
    {
        foreach (Transform point in spawnPoints)
        {
            Instantiate(playerPrefab, point.position, Quaternion.identity);
        }
    }

    void ShrinkZone()
    {
        zoneRadius -= shrinkSpeed;
    }
}
