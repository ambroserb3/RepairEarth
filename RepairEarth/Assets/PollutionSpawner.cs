using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionSpawner : MonoBehaviour
{
    public string spawnTag = "PollutionSpot";

    public float spawnTime = 1f;

    private float timeToSpawn;
    private GameObject[] spawnLocs;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocs = GameObject.FindGameObjectsWithTag(spawnTag);
        foreach (GameObject obj in spawnLocs)
        {
            obj.SetActive(false);
        }
        timeToSpawn = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (timeToSpawn <= 0)
        {
            timeToSpawn = spawnTime;
            SpawnTrash();
        }
    }

    void SpawnTrash()
    {
        int n = spawnLocs.Length;
        while (n > 1)
        {
            int k = Random.Range(0,n--);
            GameObject temp = spawnLocs[n];
            spawnLocs[n] = spawnLocs[k];
            spawnLocs[k] = temp;
        }
        foreach (GameObject obj in spawnLocs)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
                return;
            }
        }
    }

    public int NumTrash()
    {
        int numTrash = 0;
        foreach (GameObject obj in spawnLocs)
        {
            if (obj.activeSelf)
            {
                numTrash++;
            }
        }
        return numTrash;
    }

    public int TotalTrash()
    {
        return spawnLocs.Length;
    }
}
