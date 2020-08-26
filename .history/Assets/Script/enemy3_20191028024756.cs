using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public GameObject ball;
    GameObject Object;
    void Start()
    {
      Object = Instantiate(ball, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
