using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Mole : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Color circleColor;
    public Color circleColorChange;
    public float timer;
    private float privateTimer;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = circleColor;
        privateTimer = timer;
    }

    void OnMouseDown()
    {
        privateTimer = timer;
        sprite.color = circleColorChange;
    }

    // Update is called once per frame
    void Update()
    {
        privateTimer -= Time.deltaTime;
        if (privateTimer <= 0)
        {
            sprite.color = circleColor;
        }
    }
}
