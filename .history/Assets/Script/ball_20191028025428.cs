using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
      Rigidbody2D rigidbody;
      private GameObject hero;
      private float speed = 1.0f;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");

      Vector3 diff = (hero.transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
    }
}
