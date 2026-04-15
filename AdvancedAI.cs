using UnityEngine;
using UnityEngine.AI;

public class AdvancedAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float health = 100f;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);

        if (health < 30f)
        {
            Retreat();
        }
        else if (dist < 20f)
        {
            Attack();
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }

    void Attack()
    {
        Debug.Log("AI attacking");
    }

    void Retreat()
    {
        agent.SetDestination(transform.position - (player.position - transform.position));
    }
}
