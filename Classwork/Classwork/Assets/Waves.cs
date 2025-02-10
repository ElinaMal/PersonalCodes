using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new(gameObject.transform.position.x, Mathf.Sin(Time.time), gameObject.transform.position.z);
        transform.position = position;
    }
}
