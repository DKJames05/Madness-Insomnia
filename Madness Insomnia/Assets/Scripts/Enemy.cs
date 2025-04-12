using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("General Settings")]
    public float health = 100f;
    public float lookRadius = 10f;

    [Header("Patrol Settings")]
    public Transform[] patrolPoints;
    private int currentPatrolIndex = 0;

    [Header("References")]
    public Transform player;

    private NavMeshAgent agent;
    private bool isDead = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (patrolPoints.Length > 0)
            agent.destination = patrolPoints[currentPatrolIndex].position;
    }

    void Update()
    {
        if (isDead) return;

        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= lookRadius)
        {
            // Chase player
            agent.SetDestination(player.position);
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        if (agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            agent.destination = patrolPoints[currentPatrolIndex].position;
        }
    }

    public void TakeDamage(float damage)
    {
        if (isDead) return;

        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        agent.isStopped = true;
        Debug.Log($"{gameObject.name} has died.");
        // Add death animation or destroy game object here
        Destroy(gameObject, 2f); // Delay destroy for death animation
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}