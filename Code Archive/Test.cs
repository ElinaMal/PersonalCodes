using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int coinCount; //int represents WHOLE numbers
    public float xPosition; //float represents DECIMAL numbers
    public string nameOfCharacter; //string represents WORDS or PHRASES
    public bool doesDerekHaveAFavoriteStudent; //bool is a TRUE or FALSE value
    public Vector2 playerPosition; //vector2 represents 2D NUMBER
    // vector3 is 3D

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Your name is " + nameOfCharacter);

        if (doesDerekHaveAFavoriteStudent) //only run the below code IF it's currently TRUE
        {
            Debug.Log("You'll have a friend on this path with you");
        }
        else //run the code below if the if statement DID NOT EXECUTE
        {
            Debug.Log("And you'll be all alone");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey(); HOLDING down the button
        //Input.GetKeyUp(); PRESSING the button
        //Input.GetKeyDown(); RELEASING the button
    }
}
