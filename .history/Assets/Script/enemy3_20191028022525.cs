using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
