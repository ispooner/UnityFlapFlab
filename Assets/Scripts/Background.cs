using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Background : MonoBehaviour
{
    public Vector3 startPos;

    public float xScale = 1.14f;
    public Sprite background;
    public float repeatLength = 21.66f;
    public float scrollspeed;
    private float newPos = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        rend.sprite = background;
        transform.localScale = new Vector3(xScale, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Mathf.Repeat(Time.time * scrollspeed, repeatLength);
        transform.position = startPos + Vector3.right * newPos;
    }
}
