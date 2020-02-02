using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherEarth : MonoBehaviour
{
    public Sprite[] dirtyEarth;
    public Sprite[] cleanEarth;
    public PollutionSpawner pollution;
    public int threshold;
    public float animLength;

    private SpriteRenderer sprite;
    private float animTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        animTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animTime += Time.deltaTime;
        if (animTime > animLength)
        {
            animTime = 0;
        }
        if (pollution.NumTrash() > threshold)
        {
            int index = Mathf.Min(Mathf.FloorToInt(dirtyEarth.Length * (animTime / animLength)), dirtyEarth.Length - 1);
            sprite.sprite = dirtyEarth[index];
        }
        else
        {
            int index = Mathf.Min(Mathf.FloorToInt(cleanEarth.Length * (animTime / animLength)), cleanEarth.Length - 1);
            sprite.sprite = cleanEarth[index];
        }
    }
}
