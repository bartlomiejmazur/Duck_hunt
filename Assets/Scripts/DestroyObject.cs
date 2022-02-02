using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{   
    [SerializeField]
    private float speed;
    int score;
    
    
    // Start is called before the first frame update
    void Start()
    {
     
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
       
    }
   
    public  void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Score.scoreValue += 10;
            this.transform.rotation = Quaternion.Euler(0,0, -180f);
            gameObject.GetComponent<FlyScript>().enabled = false;
            Ammo.ammoAmount++;
            
            Destroy(gameObject, 0.5f);
            
            



        }
    }
   
    
}

