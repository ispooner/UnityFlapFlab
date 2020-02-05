using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public Sprite[] layers;
    public GameObject backgroundObject;
    public float speedModifier = default;
    public float baseSpeed = default;
    public int depth = default;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < layers.Length; i++)
        {
            GameObject temp = Instantiate<GameObject>(backgroundObject, new Vector3(-21.66f, 0, depth + i), Quaternion.identity, transform);
            Background back = temp.GetComponent<Background>();
            back.background = layers[i];
            back.scrollspeed = baseSpeed * (Mathf.Pow( speedModifier, i));
            
            temp = Instantiate<GameObject>(backgroundObject, new Vector3(0f, 0, depth + i), Quaternion.identity, transform);
            back = temp.GetComponent<Background>();
            back.background = layers[i];
            back.scrollspeed = baseSpeed * (Mathf.Pow(speedModifier, i));
        }
    }
}
