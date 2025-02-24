using UnityEngine;

public class RadiansAndDegrees : MonoBehaviour
{
    [SerializeField] double degrees;
    [SerializeField] double radians;

    private double degreesResult;
    private double radiansResult;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        radiansResult = degrees * (radians / 180);
        degreesResult = radians * (degrees / 3.14);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
