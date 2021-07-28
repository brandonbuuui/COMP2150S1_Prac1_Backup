using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Mole : MonoBehaviour
{
    public Color circleColor;
    public Color circleColorChange;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.color = circleColor;
    }

    void OnMouseDown()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.color = circleColorChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
