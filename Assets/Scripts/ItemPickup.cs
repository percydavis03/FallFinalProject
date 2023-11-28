using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ItemPickup : MonoBehaviour
{
    public Item Item;
    public bool canPickup = false;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
      canPickup = true;
    }

    /*private void Update()
    {
        if (canPickup)
        {
            if (Keyboard.current.fKey.isPressed)
            {
                Pickup();
            }
        }
        
    }*/
    private void OnMouseDown()
    {
        Pickup();
    }
}
