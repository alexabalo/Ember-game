using UnityEngine;

public class SumarObjeto : MonoBehaviour
{
    public int cantidad = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ember_0")
        {
            Movimientos p = collision.GetComponent<Movimientos>();

            p.fireObtenido += cantidad;

            Debug.Log(cantidad + "fuegos obtenidos");
            Debug.Log("Tenes " + p.fireObtenido);

            gameObject.SetActive(false);
        }
        
    }
}
