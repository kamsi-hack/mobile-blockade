using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public float radius = 300f;
    public float shrinkRate = 1f;

    void Update()
    {
        radius -= shrinkRate * Time.deltaTime;
        transform.localScale = new Vector3(radius, 1, radius);
    }
}
