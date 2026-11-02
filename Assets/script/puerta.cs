using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour

{
    [SerializeField] private string level2;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(level2);
        }
    }
}