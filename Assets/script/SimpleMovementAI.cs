using UnityEngine;

public class SimpleMovementAI : MonoBehaviour
{
    public Transform target; // el objetivo al cual se movera

    public float speed = 2f; // Velocidad del npc

    public float detectionRange = 5f; // Rango de deteccion

    void Update()
    {
        //Calculamos la distancia entre el Npc y el objetivo
        float distance = Vector3.Distance(transform.position, target.position);
        //si la distancia es menor al rango de deteccion, el npc se mueve hacia el jugador
        if( distance < detectionRange)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            //so esta fuera del rango, el npc se detiene
            //podriamos agregar otra logica aca si queremos que haga otra cosa

        }
    }
}
