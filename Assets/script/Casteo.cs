using UnityEngine;

public class Casteo : MonoBehaviour
{
   void Start()

    {   //tengo un valor decimal
        float f1 = 9.9f;

        //Castreo de float a int
        int n1 = (int)f1;

        //mostramos los valores
        Debug.Log("Valor original de f1: " + f1);
        Debug.Log("Valor de n1 despues del casteo: " + n1);

        //Convertir float a string usando ToString()
        string t1 = f1.ToString();

        //mostrarmos el resultado
        Debug.Log("Valor de t1 como string: " + t1);
    }
}
