using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyInfiniteScroling : MonoBehaviour { 

    public float ScrollSpeed;
    private Vector2 offset;
    void Update()
    {
        offset = new Vector2(Time.time * ScrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
