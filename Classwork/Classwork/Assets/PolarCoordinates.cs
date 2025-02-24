using UnityEngine;

public class PolarCoordinates : MonoBehaviour
{
    [SerializeField] float coordinateX;
    [SerializeField] float coordinateY;

    [SerializeField] float radius;
    [SerializeField] float angleDegrees;

    private float foundRadius;
    private float foundAngleDegrees;
    private float foundX;
    private float foundY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float squaredX = coordinateX * coordinateX;
        float squaredY = coordinateY * coordinateY;

        foundRadius = Mathf.Sqrt(squaredX + squaredY);

        if (coordinateX > 0)
        {
            foundAngleDegrees = (Mathf.Atan2(coordinateX, coordinateY) * Mathf.Rad2Deg) + 180;
        }
        else
        {
            foundAngleDegrees = Mathf.Atan2(coordinateX, coordinateY);
        }
        
        foundX = radius * Mathf.Cos(angleDegrees);

        foundY = radius * Mathf.Sin(angleDegrees);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
