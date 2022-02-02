using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applemovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Random.Range(-7, 7);
        float yVel = Random.Range(1, 4);
        float xVel = Random.Range(-4, 4);
        if (this.transform.position.y < -6)
        {
            xPos = Random.Range(-7, 7);
            if (xPos > -3)
                xVel = Random.Range(-1, 6);
           else if (xPos < 3)
                xVel = Random.Range(-6, 1);
            
            this.transform.position = new Vector2(xPos, -6);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
            this.GetComponent<Rigidbody2D>().AddTorque(15);
        }
        
        
    }
}
