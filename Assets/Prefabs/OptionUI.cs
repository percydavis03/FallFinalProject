using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionUI : MonoBehaviour
{
    public Text OptionText;
    public Image seletionIndicator;
    public Image backgroundImage;

    public void SetOptionText(string text)
    {
        OptionText.text = text;
    }
    

    public void SetSelected(bool selcted)
    {
        if (selcted)
        {
            seletionIndicator.gameObject.SetActive(true);
            backgroundImage.color = new Color(0.6896307f, 0.2509804f, 0.9339623f);
        }
        else
        {
            seletionIndicator.gameObject.SetActive(false);
            backgroundImage.color = new Color(0.5850676f, 0.4789961f, 0.8679245f);
        }
    }

    public void SetVisible(bool visible)
    {
        OptionText.gameObject.SetActive(visible);
        seletionIndicator.gameObject.SetActive(visible);
        backgroundImage.gameObject.SetActive(visible);
    }
}
