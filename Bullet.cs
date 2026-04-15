using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 30f;

    void OnCollisionEnter(Collision collision)
    {
        EnemyAI enemy = collision.transform.GetComponent<EnemyAI>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
