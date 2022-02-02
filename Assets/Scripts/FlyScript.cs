using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public float speed = 2.5f;
    float startX;
    float startY;
    public float distanceX = 5;
    public float distanceY = 1;
    float addX;
    float addY;
    Vector2 posLastFrame;
    Vector2 posThisFrame;

    void Start()
    {
        speed = Random.Range(1f, 2.5f);//
        Shader.SetGlobalFloat(1, speed);
        startX = transform.position.x;
        startY = transform.position.y;
    }

    void Update()
    {
        addX = duckTransition(Time.time * Shader.GetGlobalFloat(1), distanceX);
        addY = duckTransition(Time.time * Shader.GetGlobalFloat(1), distanceY);
        transform.position = new Vector3(startX + addX, startY + addY, transform.position.z);
        posLastFrame = posThisFrame;
        posThisFrame = transform.position;

        if (posThisFrame.x <= posLastFrame.x) { 
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else{
            transform.localScale = new Vector3(1, 1, 1);
            }


        // if(false)
        // transform.localScale = new Vector3(-1, 1, 1);

    }
    private float duckTransition(float t, float length)
    {
        t = Mathf.Repeat(t, length * 2f);
        return length - Mathf.Abs(t - length);
    }
    
}

