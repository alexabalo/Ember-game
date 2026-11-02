using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int myCount = 1;

    //identificador del objeto
    public string objID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TOQUE ALGOl: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("ES LE PLAYER");

            ItemManager inv = collision.GetComponent<ItemManager>();

            if (inv == null)
            {
                Debug.LogError("EL PLAYER NO TIENE ItemManager");
                return;

            }

            Debug.Log("ENCONTRE EL ITEM MANAGER");

            foreach (KeyValuePair<GameObject, int> items in inv.inventory)
            {
                Debug.Log("REVISANDO: " + items.Key.name);

                Item invID = items.Key.GetComponent<Item>();

                if(invID == null)
                {
                    Debug.LogError("EL PREFAB " + items.Key.name + " NO TIENE COMPONENTE ITEM");
                    continue;
                }

                Debug.Log("ID inventario: " + invID.objID);
                Debug.Log("ID objeto tocado: " + objID);

                if(invID.objID == objID)
                {
                    Debug.Log("¡Coincide!");

                    inv.inventory[items.Key] += myCount;

                    Debug.Log("Tenes " + inv.inventory[items.Key] + " " + items.Key);

                    Destroy(gameObject, 0.2f);

                    break;
                }    
            }
        }    
    }
}
