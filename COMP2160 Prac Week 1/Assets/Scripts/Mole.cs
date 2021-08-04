using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Mole : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Color upColor;
    public Color downColor;
    public Color missedColor;
    public float timer;
    public float ranTime;
    private float privateTimer;
    private float missTimer;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = downColor;
        privateTimer = timer;
        missTimer = timer;
        ranTime = Random.Range(1, 5);
    }

    void OnMouseDown()
    {
        if (sprite.color == upColor)
        {
            sprite.color = downColor;
            ranTime = Random.Range(1, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ranTime -= Time.deltaTime;
        if (ranTime < 0)
        {
            sprite.color = upColor;
            privateTimer -= Time.deltaTime;
            if (privateTimer < 0)
            {
                sprite.color = missedColor;
                missTimer -= Time.deltaTime;
                if (missTimer < 0)
                {
                    ranTime = Random.Range(1, 5);
                    privateTimer = timer;
                    missTimer = timer;
                    sprite.color = downColor;
                }
            }
        }
    }
}
