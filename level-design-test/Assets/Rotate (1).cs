using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    public bool xAxis;
    public bool yAxis;
    public bool zAxis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (xAxis == true)
        {
            transform.Rotate(speed, 0, 0, Space.Self);
        }
        if (yAxis == true)
        {
            transform.Rotate( 0, speed, 0, Space.Self);
        }
        if (zAxis == true)
        {
            transform.Rotate(0, 0, speed, Space.Self);
        }

    }
}
