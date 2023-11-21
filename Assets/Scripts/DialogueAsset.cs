using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Dialogue Asset")]

public class DialogAsset : ScriptableObject
{
    public TextAsset storyJson;
    public Sprite portrait;
    public RuntimeAnimatorController animatorController;
}
