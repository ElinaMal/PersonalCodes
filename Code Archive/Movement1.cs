using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S;
    public float speed = 8, jumpHeight = 15;
    public KeyCode jump = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey(); HOLDING down the button
        //Input.GetKeyUp(); PRESSING the button
        //Input.GetKeyDown(); RELEASING the button

        if (Input.GetKey(left)) //check for the player HOLDING DOWN the left button
        {
            //get the GameObject's Rigidbody2D component and set its velocity to be to the left at the given speed
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }

        if (Input.GetKey(right)) //check for the player HOLDING DOWN the right button
        {
            //get the GameObject's Rigidbody2D component and set its velocity to be to the right at the given speed
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }

        if (Input.GetKey(up)) //check for the player HOLDING DOWN the up button
        {
            //get the GameObject's Rigidbody2D component and set its velocity to be up at the given speed
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }

        if (Input.GetKey(down)) //check for the player HOLDING DOWN the down button
        {
            //get the GameObject's Rigidbody2D component and set its velocity to be down at the given speed
            GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        }

        if (Input.GetKeyDown(jump)) //check for the player PRESSING the jump button
        {
            //get the GameObject's Rigidbody2D component and set its velocity to be up at the jump height
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;
        }
    }
}
