
using UnityEngine;

public class Patrullaje4 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform player;

    public float speed = 3f;
    public float detectionRange = 7f;

    private Transform currentTarget;

    void Start()
    {
        if (pointA != null)
        {
            currentTarget = pointA;
        }
    }

    void Update()
    {
        if (pointA == null || pointB == null || player == null)
            return;

        float playerDistance = Vector3.Distance(
            transform.position,
            player.position
        );

        if (playerDistance < detectionRange)
        {
            MoveTowards(player.position);
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        float distanceToTarget = Vector3.Distance(
            transform.position,
            currentTarget.position
        );

        if (distanceToTarget < 0.1f)
        {
            currentTarget = currentTarget == pointA
                ? pointB
                : pointA;
        }

        MoveTowards(currentTarget.position);
    }

    void MoveTowards(Vector3 targetPosition)
    {
        Vector3 direction =
            (targetPosition - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;
    }
}
