using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectibles : MonoBehaviour
{
    public Slider pollution;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pollution.value <= 0)
        {
            Debug.Log("Pollution Ending.");
        }
        if (pollution.value >= 1)
        {
            Debug.Log("Earth Ending.");
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            pollution.value += .05F;
            gameObject.SetActive(false);
        }
    }
}

