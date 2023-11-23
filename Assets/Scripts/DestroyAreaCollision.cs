using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAreaCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag != "BG")
        {
           Destroy(collision.gameObject);
            print("Destroyed"); 
        }
            
    }
}
