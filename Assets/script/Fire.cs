using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private int cantidad = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log(cantidad + "fuegos obtenidos");

            gameObject.SetActive(false);

        }

       

    }
        
    
}
