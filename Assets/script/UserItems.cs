using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UserItems : MonoBehaviour
{
    [SerializeField]

    private ItemManager im;

    [SerializeField]

    private int vida = 50;


     void Start()
    {

        im = GetComponent<ItemManager>();
        
    }

     void Update()
    {
        UsingHealingPotion2();
    }

    private void UsingHealingPotion2()
    {
        if( Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Apreta la tecla 2");

            foreach (KeyValuePair<GameObject, int> items in im.inventory)
            {
                Debug.Log("Estoy revisando: " + items.Key.name);

                Item obj = items.Key.GetComponent<Item>();

                Debug.Log("ID encontrado: " + obj.objID);
                Debug.Log("Cantidad: " + items.Value);

                if(obj.objID == "heart")
                {
                    Debug.Log("Encontre la posion");

                    if(items.Value > 0)
                    {
                        vida += 10;

                        Debug.Log("Vida actual: " + vida);

                        im.inventory[items.Key] -= 1;

                        Debug.Log("Posiones restantes: " + im.inventory[items.Key]);

                        break;
                    }



                }
            }
        }
    }
    }
