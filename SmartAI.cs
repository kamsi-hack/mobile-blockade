using UnityEngine;
using UnityEngine.AI;

public class SmartAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float attackRange = 15f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > attackRange)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("Bot Shooting!");
    }
}
