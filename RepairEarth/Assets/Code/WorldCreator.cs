using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    public GameObject dirtGround;
    private Vector3 startLoc = new Vector3(-100, -1.7f, 2);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(dirtGround, startLoc, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
