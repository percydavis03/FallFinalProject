using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HagstonePickedup : MonoBehaviour
{
    public Item Item;
    public bool canPickup = false;
    private bool addItem = true;
    public GameObject hagstoneInstructions;
    public GameObject pickupInstructions;
    public GameObject hagstoneMesh;
    void Pickup()
    {
        Invoke("InstructionsGoAway", 5.0f);
        if (addItem == true)
        {
            InventoryManager.Instance.Add(Item);
            addItem = false;    
        }
        pickupInstructions.SetActive(false);
        hagstoneInstructions.SetActive(true);
        hagstoneMesh.SetActive(false);
    }

    
    void InstructionsGoAway()
    {
        hagstoneInstructions.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (addItem == true) 
        {
            pickupInstructions.SetActive(true);
            canPickup = true;
        }
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
