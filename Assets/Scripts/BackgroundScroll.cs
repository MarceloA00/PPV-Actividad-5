using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), 0);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "BGLimit") {
            transform.position = new Vector3(2.54633665f,23f,0);
        }
    }
}
