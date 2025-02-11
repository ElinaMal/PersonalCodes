using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCalculator : MonoBehaviour
{
    public GameObject findObject;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        float x1 = findObject.transform.position.x;
        float y1 = findObject.transform.position.y;

        float x2 = gameObject.transform.position.x;
        float y2 = gameObject.transform.position.y;

        Angle(x1, y1, x2, y2);

        Debug.Log(angle);
    }

    public void Angle(float x1, float y1, float x2, float y2)
    {
        float distanceX = x2 - x1;
        float distanceY = y2 - y1;

        float oppOverAdj = distanceY/distanceX;

        angle = Mathf.Atan(oppOverAdj) * Mathf.Rad2Deg;
    }
}
