using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    public static ImageManager instance;
    private SpriteRenderer spriterenderer;
   

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }
    public void showImage(string Imagename)
    {
        spriterenderer.sprite = Resources.Load<Sprite>(Imagename); 
    }
}
