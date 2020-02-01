using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    public GameObject dirtGround;
    public GameObject water;
    private Vector3 startLoc = new Vector3(0, -2f, 2);

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D collider = (BoxCollider2D)dirtGround.gameObject.GetComponent<Collider2D>();
        for (int i = -100; i <= 100; ++i)
        {
            for (int j = -5; j <= 0; ++j)
            {

                if (i < -80 || i > -20)
                {
                    Instantiate(dirtGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(water, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
