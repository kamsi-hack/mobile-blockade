using UnityEngine;

public class MobileControls : MonoBehaviour
{
    public float speed = 5f;

    public void Move(float x, float z)
    {
        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }
}
