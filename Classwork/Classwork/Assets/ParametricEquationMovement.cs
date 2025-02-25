using UnityEngine;

public class ParametricEquationMovement : MonoBehaviour
{
    [SerializeField] float width;
    [SerializeField] float height;
    [SerializeField] int waves;
    [SerializeField] float alterLocation;
    [SerializeField] int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string check = waves.ToString();

        if (int.TryParse(check, out waves))
        {

        }
        else
        {
            waves = Mathf.RoundToInt(waves);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time * speed;

        float x = width * (Mathf.Sin(waves * time + alterLocation));
        float y = height * (Mathf.Sin(time));
        float z = 4;

        transform.position = new Vector3(x, y, z);
    }
}
