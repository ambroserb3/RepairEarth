using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    private float startX;
    private float playerStartX;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        playerStartX = player.position.x; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x = startX + player.position.x - playerStartX;
        transform.position = newPos;
    }
}
