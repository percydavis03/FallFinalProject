using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startbutton : MonoBehaviour
{
    public Button button;
    private void TutorialLevel()
    {
        SceneManager.LoadScene("TutorialLevel");
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(TutorialLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
