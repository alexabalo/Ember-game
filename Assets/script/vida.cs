using UnityEngine;

public class vida : MonoBehaviour
{
    int letvida = 0;

    void CambiarVida(int a)
    {
        letvida += a;
    }

        private void Start()

    {
        CambiarVida(100);
        print("vida actual:" + letvida);
    }

     void Update()
    {
        
    }

}
