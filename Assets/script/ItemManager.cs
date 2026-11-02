using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //La lista puede creecer o reducirse
    public List<GameObject> gameItems;

    public Dictionary<GameObject, int> inventory =
        new Dictionary<GameObject, int>();

     void Start()
    {
        //esta linea se comunica con la carpeta Resource(que puede llamarse de cualquier nombre), y trae todos los objetos.
        gameItems = new List<GameObject>(
            Resources.LoadAll<GameObject>("Pick")
            );

        Debug.Log("Cantidad de objetos encontrados: " + gameItems.Count);

        for(int i = 0; i < gameItems.Count; i++)
        {
            Debug.Log("Agregado al inventario: " + gameItems[i].name);

            inventory.Add(gameItems[i], 0);


        }      
        
        foreach (KeyValuePair<GameObject, int> items in inventory)
        {
            Debug.Log("Inventario: " + items.Key.name + " | Cantidad: " + items.Value);


        }
        
    }
}
