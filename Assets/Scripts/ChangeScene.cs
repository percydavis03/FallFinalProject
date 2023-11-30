using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int where; 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(where);
    }
    
    
}
