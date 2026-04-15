using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float health = 100f;
    public Transform player;
    public float speed = 3f;

    void Update()
    {
        if (player != null)
        {
            transform.LookAt(player);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
