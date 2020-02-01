using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class StoryLine
{
    public string line;
}

public class TextManager : MonoBehaviour
{

    public StoryLine[] story;
    public Text textBox;

    void SetText(int index)
    {
        textBox.text = story[index].line;
    }
}
