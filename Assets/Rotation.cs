using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Rotate = 200;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * Rotate;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
