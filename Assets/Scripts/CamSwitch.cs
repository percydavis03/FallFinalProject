using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamSwitch : MonoBehaviour
{
    public GameObject maincam;
    public GameObject Hagstonecam;
    public GameObject Hagstone;
    private bool stoneisActive;

    public bool gotHagstone;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
            if (scene.name != "Tutorial Level" && scene.name != "Level1")
        {
            gotHagstone = true;
        }
        else
        {
            gotHagstone = false;
        }
               
        
    }
    void Update()
    {
        if (gotHagstone == true)
        {
            print(stoneisActive);
            if (Input.GetKeyDown(KeyCode.C))
            {
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
}
