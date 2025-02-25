using UnityEngine;

public class Logarithms : MonoBehaviour
{
    private float result;
    [SerializeField] float a;
    [SerializeField] float x;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float logarithms = Mathf.Log(x, a);
        float exponential = Mathf.Pow(a, logarithms);
    }
}
