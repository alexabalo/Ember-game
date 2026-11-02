using UnityEngine;

public class Berserk : MonoBehaviour
{
    //variable del enemigo
    private int vida = 100;

    private int daño = 10;

    private bool BerserkOn;

    [SerializeField]

    private Timer timer;

    void Start()
    {
        Debug.Log("Vida del enemigo: " + vida);
        Debug.Log("Daño inicial: " + daño);
    }

    void Update()
    {
        //si todavia Noo esta en estado Berserk
        //y el tiempo llego a 0
        if (!BerserkOn && timer.tiempoRestante <= 0)
        {
            //activamos el modo berserk
            BerserkOn = true;

            //mostramos  el mensjae
            Debug.Log("Modo salvaje");

            //duplicamos el daño
            daño *= 2;

            //mostramos el nuevo daño
            Debug.Log("Nuevo daño: " + daño);
        }
        
    }
}
