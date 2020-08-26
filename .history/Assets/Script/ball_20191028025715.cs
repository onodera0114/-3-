using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
      Rigidbody2D rigidbody;
      private GameObject hero;
      private float speed = 1.0f;
      private Vector3 diff;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");

      diff = (hero.transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 diff = (hero.transform.position - transform.position);
      rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
    }
}
