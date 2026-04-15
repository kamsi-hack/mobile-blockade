using UnityEngine;

public class ZoneDamage : MonoBehaviour
{
    public float radius;
    public float damage = 5f;
    public Transform center;

    void Update()
    {
        Collider[] players = Physics.OverlapSphere(center.position, 500f);

        foreach (Collider p in players)
        {
            float dist = Vector3.Distance(center.position, p.transform.position);

            if (dist > radius)
            {
                PlayerHealth ph = p.GetComponent<PlayerHealth>();
                if (ph != null)
                {
                    ph.TakeDamage(damage * Time.deltaTime);
                }
            }
        }
    }
}
