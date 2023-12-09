using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphamaterail : MonoBehaviour
{
    private Material invisible;

    // Start is called before the first frame update
    void Start()
    {
        invisible = GetComponent<Material>();
        invisible.color = new Color(255f, 255f, 255f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
