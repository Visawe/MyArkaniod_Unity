using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockBlueMove : MonoBehaviour {
    public float speed = 50.0f;
    public bool toRight = true;
   

    // Use this for initialization
    void Start () {
       
        
        this.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        

    }

    // Update is called once per frame
    void Update () {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        //if (col.gameObject.tag == "Wall" || col.gameObject.tag == "block")
        if (col.gameObject.tag == "Wall")
        {
            if (toRight)
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
                toRight = false;
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
                toRight = true;
            }
        }
        
    }
    
}
