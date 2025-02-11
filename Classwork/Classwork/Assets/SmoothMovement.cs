using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    private float startPointX;
    private float startPointY;
    private float startPointZ;

    [SerializeField] float endPointX;
    [SerializeField] float endPointY;
    [SerializeField] float endPointZ;

    private float timeThing = 0;

    private bool increasing = true;

    // Start is called before the first frame update
    void Start()
    {
        startPointX = transform.position.x;
        startPointY = transform.position.y;
        startPointZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (increasing == true)
        {
            timeThing += Time.deltaTime;

            if (timeThing > 1)
            {
                increasing = false;
            }
        }
        else if (increasing == false)
        {
            timeThing -= Time.deltaTime;

            if (timeThing < 0)
            {
                increasing = true;
            }
        }

        transform.position = new Vector3(Mathf.Lerp(startPointX, endPointX, timeThing), 
            Mathf.Lerp(startPointY, endPointY, timeThing), 
            Mathf.Lerp(startPointZ, endPointZ, timeThing));
    }
}
