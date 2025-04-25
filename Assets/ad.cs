using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ad : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Ad_change()
    {

    }

    public void turn_on_gravity()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

    }
}


