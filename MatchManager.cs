using UnityEngine;

public class MatchManager : MonoBehaviour
{
    public int playersAlive = 10;

    void Update()
    {
        if (playersAlive <= 1)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Winner!");
    }
}
