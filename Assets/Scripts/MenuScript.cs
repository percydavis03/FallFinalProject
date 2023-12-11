using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject menu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.activeInHierarchy)
            {
                menu.SetActive(false);
                print("we are inactive");
            }
            else
            {
                menu.SetActive(true);
            }
        }
    }

    public void Resume()
    {
        menu.SetActive(false);
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void Exit()
    {
       Application.Quit();
        Debug.Log("leave the game");
    }


}
