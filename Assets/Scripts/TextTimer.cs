using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    public GameObject movementText;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InstructionsGoAway", 6.0f);
    }
    void InstructionsGoAway() 
    {
        movementText.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
