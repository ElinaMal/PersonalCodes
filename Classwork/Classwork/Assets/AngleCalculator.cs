using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCalculator : MonoBehaviour
{
    public GameObject findObject;

    // Start is called before the first frame update
    void Start()
    {
        float x1 = findObject.transform.position.x;
        float y1 = findObject.transform.position.y;

        float x2 = gameObject.transform.position.x;
        float y2 = gameObject.transform.position.y;
    }

    public void Angle(float x1, float y1, float x2, float y2)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
