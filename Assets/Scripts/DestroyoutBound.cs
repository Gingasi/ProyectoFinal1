using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyoutBound : MonoBehaviour
{
    private float lowerLim = 22f;
    private float yMax = 200f;
    private float xMax = 320f;
    private float zMax = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xMax)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > yMax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < lowerLim)
        {
            Destroy(gameObject);

        }
        if (transform.position.z > zMax)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zMax)
        {
            Destroy(gameObject);
        }
    }
}
