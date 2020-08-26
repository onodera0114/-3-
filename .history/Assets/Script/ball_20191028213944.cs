﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
      Rigidbody2D rigidbody;
      private GameObject hero;
      private float speed = 0.8f;
      private Vector3 diff;
      private float deltaTime = 0;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");

      diff = (hero.transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
      deltaTime++;

      if(deltaTime > 120.0f){
        Destroy(this.gameObject);
      }
    }

    private void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag == "hero"){
        Destroy(this.gameObject);
      }
    }
}
