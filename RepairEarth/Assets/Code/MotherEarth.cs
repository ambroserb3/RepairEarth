using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherEarth : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        // Make a text field that modifies stringToEdit.
        GUI.Label(new Rect(position.x - 100, Screen.height - position.y + 300, 200, 1000), getSpeechString());
    }

    string getSpeechString()
    {
        return "Hello zoomer ;) I am Stepmother Earth. I just broke up with the Boomers because they didn't treat me right and polluted my body. Can you help clean me up?";
    }
}
