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

        List<float> treeLocs = new List<float>();
        treeLocs.Add(-95);
        treeLocs.Add(-90f);
        treeLocs.Add(-89f);
        treeLocs.Add(-88.5f);
        treeLocs.Add(-18f);
        treeLocs.Add(-17f);
        treeLocs.Add(-16f);
        treeLocs.Add(-15.5f);
        treeLocs.Add(-14f);
        treeLocs.Add(20f);
        treeLocs.Add(25f);
        treeLocs.Add(28f);
        treeLocs.Add(30f);
        treeLocs.Add(30.5f);
        treeLocs.Add(60f);
        treeLocs.Add(61f);
        treeLocs.Add(62f);
        treeLocs.Add(62.5f);
        treeLocs.Add(63f);
        treeLocs.Add(87f);
        treeLocs.Add(88f);

        for (int i = 0; i < treeLocs.Count; ++i)
        {
            float loc = treeLocs[i];
            GameObject toMake = treeYellow;
            if (treeLocs[i] > -20)
            {
                if (treeLocs[i] < 40)
                {
                    toMake = treeWhite;
                } else
                {
                    toMake = treeGreen;
                }
            }

            Instantiate(toMake, startLoc + new Vector3(i, 0, 2), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
