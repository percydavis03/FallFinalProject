using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenInventoy : MonoBehaviour
{
    public GameObject inventoryUI;

    private void Start()
    {
        inventoryUI.SetActive(false);
    }
    
    void Update()
    {
        if (Keyboard.current.tabKey.isPressed)
        {
            if (!inventoryUI.activeSelf)
            {
                inventoryUI.SetActive(true);
            }
            else if (inventoryUI.activeSelf)
            {
                inventoryUI.SetActive(false);
            }
        }
        
    }
}
