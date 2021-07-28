using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Mole : MonoBehaviour
{
    public Color circleColor;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.color = circleColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
