using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CamSwitch : MonoBehaviour
{
    public GameObject maincam;
    public GameObject Hagstonecam;
    public GameObject Hagstone;
    private bool stoneisActive;
    private bool itemActive;
    private List<Item> Itemsholder = new List<Item>();
    void Update()
    {
        //Itemsholder = InventoryManager.Instance.Items;
        /*foreach(Item item in Itemsholder)
        {
            if (item.name == "Stone")
            {
                
                itemActive = true;
                return;
            }
            
        }*/
        print(itemActive);
        if (Input.GetKeyDown(KeyCode.C) && InventoryManager.Instance.itemActive == true)
        {
            print("Active");
            if (stoneisActive == false)
            {
                maincam.SetActive(false);
                Hagstonecam.SetActive(true);
                Hagstone.SetActive(true);
                stoneisActive = true;
              
            }
            else
            {
                maincam.SetActive(true);
                Hagstonecam.SetActive(false);
                Hagstone.SetActive(false);
                stoneisActive = false;
            }
        }

    }
}
