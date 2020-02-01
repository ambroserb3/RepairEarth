using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public Transform parallaxBg;
    public float parallaxScale = 0.1f;
    private float startX;
    private float playerStartX;
    private float startParallaxX;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        playerStartX = player.position.x;
        startParallaxX = parallaxBg.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x = startX + player.position.x - playerStartX;
        transform.position = newPos;
        Vector3 newParallaxPos = parallaxBg.position;
        newParallaxPos.x = startParallaxX - (player.position.x - playerStartX) * parallaxScale;
        parallaxBg.localPosition = newParallaxPos;
    }
}
