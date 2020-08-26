using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private SpriteRenderer sr = null;
    private GameObject hero;
    private float speed = 0.6f;
    void Start()
    {
      sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");
      if (sr.isVisible){
        Vector3 diff = (hero.transform.position - transform.position);
        rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
        Debug.Log("見えとる");
      }
    }
}
