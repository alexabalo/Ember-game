using UnityEngine;

public class Name : MonoBehaviour
{
    public int cantidad = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == ("Ember_0"))
        {
            Debug.Log(cantidad + "fuego obtenido");
            gameObject.SetActive(false);
        }
        
    }
}

