using System.Collections.Generic;
using UnityEngine;

public class PatrullajeEnemigo : MonoBehaviour
{
    public float detectionRange = 5f; //Rango en el que el objeto detecta enemigos
                                      //lista para llevar registros de los enemigos que ya fueron dertectados

    private List<GameObject>detectedEnemies = new List<GameObject>();

     void Update()
    {
        //obtiene todos los objetos activos en la escena con la etiqueta "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //Recirre cada enemigo encontrado
        foreach (GameObject enemy in enemies)
        {
            //Calcula la distrancia entre este objeto y el enemigo
            float distance = Vector3.Distance(transform.position,enemy.transform.position);

            //si el enemigo esta dentro del rango de deteccion
            if (distance < detectionRange)
            {
                // y aun no esta en la lista de detectados
                if(!detectedEnemies.Contains(enemy))
                {
                    // entonces lo detectamos por primera vez
                    Debug.Log("Enemigo detectado" + enemy.gameObject.name);

                    //lo agregamos a la lista para que no se vuelva a detectar hasta que 
                    detectedEnemies.Add(enemy);

                    //aca se podria agregar mas logica como alertas ataques o cambiar de color
                }
            }

            else if (detectedEnemies.Contains(enemy))
            {
                // lo eliminamos de la lista
                detectedEnemies.Remove(enemy);
                //esto permite que, si vuelve a entrar al rango, sea detectado otra vez
                Debug.Log(enemy.gameObject.name + " fuera de alcance");
            }
        }
        
    }
}
