using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMap : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "EndMap")
        {
            Destroy(this.gameObject);
        }
    }
}
