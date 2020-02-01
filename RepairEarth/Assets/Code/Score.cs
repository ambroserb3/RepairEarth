using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Slider pollution;
    private float timeLeft = 5f;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft += Time.deltaTime;
        if (timeLeft < 0)
        {
            pollution.value -= .01F;
            timeLeft = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
