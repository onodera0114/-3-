using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
      Rigidbody2D rigidbody;
      private GameObject hero;
      private float speed = 10.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");
      Vector3 diff = (hero.transform.position - transform.position);
      rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
    }
}
