using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SimplePatrolAI: MonoBehaviour
{
    public Transform pointA; //punto A de patrullaje

    public Transform pointB; // punto B de patrullaje

    public float speed = 2f; //Velocidad de patrullaje

    private Transform currentTarget;

    void Start()
    {
        //Inicia moviendose hacia el punto A
        currentTarget = pointA;
        
    }

    void Update()
    {
        //Calcula la distancia hacia el objetivo actual
        float distance = Vector3.Distance(transform.position, currentTarget.position);
        //Si esta cerca del objetivo, cambia al otro lado
        if(distance < 0.1f)
        {
            currentTarget = currentTarget == pointA ? pointB : pointA;
        }

        //mueve el npc hacia el objetivo actual
        Vector3 direction = (currentTarget.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
