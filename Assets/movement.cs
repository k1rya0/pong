using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public KeyCode Upkey;
    public KeyCode Downkey;
    public float speed = 2;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        print("hey from start");
        
    }


    void Update()
   {
        /*if (transform.position.y > 4 || transform.position.y < 4
            {
            rigidbody2D.velocity = Vector2.up * speed;
             }*/

        if (Input.GetKey(Upkey) && transform.position.y < 4)
        {
            rigidbody2D.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(Downkey) && transform.position.y > -4)
        {
            rigidbody2D.velocity = Vector2.down * speed;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero; 
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.green;

    }
}
