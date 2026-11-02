using UnityEngine;
using UnityEngine.Rendering;

public class Timer : MonoBehaviour
{
    //variable que almacenta el tiempo restante
    public float tiempoRestante = 10f;

    //booleano para saver si el timer esta funcionando
    private bool timerOn;

    //variable que mostraremos en consola
    private int tiempoMostrado;

    void Start()

    {
        timerOn = true;
    }

     void Update()
    {
        //revisamos constantementre el estado del timer
        TimerCheck();
        
    }

    private void TimerCheck()
    {
        //si el timer esta activado
        if(timerOn)
        {
            //si todavia queda tiempo
            if(tiempoRestante > 0)
            {

                //Restamos el tiempo que paso desde el ultimo frame,
                //el deltaTime, representa cuanto tiempo paso desde el ultimo frame
                tiempoRestante -= Time.deltaTime;

                //casteo
                //convertimos el float a int
                tiempoMostrado = (int)tiempoRestante;
            }

            else
            {
                //avisameos quue termino el tiempo
                Debug.Log("¡Se termino el timepo!");

                //evitamos que quede un numero negativo
                tiempoRestante = 0;

                //mostramos 0 en la consola
                tiempoMostrado = 0;

            }
        }
    }


}
