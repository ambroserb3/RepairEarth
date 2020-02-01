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
    public PollutionSpawner pollution;

    void Update()
    {
        int index = Mathf.FloorToInt((story.Length - 1) * (0.0001f + ((float) pollution.NumTrash()) / pollution.TotalTrash()));
        SetText(index);
    }

    public void SetText(int index)
    {
        textBox.text = story[index].line;
    }
}
