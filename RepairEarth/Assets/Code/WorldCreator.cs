using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    public GameObject dirtGround;
    public GameObject water;
    public GameObject grassGround;
    public GameObject treeGreen;
    public GameObject treeWhite;
    public GameObject treeYellow;

    public Vector3 startLoc = new Vector3(0, -2f, 2);

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
                    if (j != 0)
                    {
                        Instantiate(dirtGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(grassGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                    }
                }

                else
                {
                    Instantiate(water, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                }
            }
        }

        for (int i = -101; i <= 101; i += 202)
        {
            for (int j = -5; j < 5; ++j)
            {
                Instantiate(dirtGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
            }
        }

        for (int i = -90; i <= 90; ++i)
        {
            if (i < -80 || i > -20)
            {
                if (j != 0)
                {
                    Instantiate(dirtGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(grassGround, startLoc + new Vector3(i, j, 0), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
