using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class ItemPickup : MonoBehaviour
{
    public Item Item;
    public bool canPickup = false;
    public GameObject pickupInstructions;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        pickupInstructions.SetActive(false);
        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        pickupInstructions.SetActive(true);
        canPickup = true;
    }

    private void OnTriggerExit(Collider other)
    {
        pickupInstructions.SetActive(false);
        canPickup = false;
    }

    private void Update()
    {
        if (canPickup)
        {
            if (Keyboard.current.rKey.isPressed)
            {
                
                Pickup();
            }
        }
        
    }
    private void OnMouseDown()
    {
        Pickup();
    }
}
