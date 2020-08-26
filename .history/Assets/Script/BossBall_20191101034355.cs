using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private GameObject hero;
    private float speed = 10f;
    private Vector3 diff;
    private float deltaTime = 0;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody.velocity = new Vector3(1f * speed, 1f * speed);
      deltaTime++;

      if(deltaTime > 200.0f){
        Destroy(this.gameObject);
      }
    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "hero"){
        Destroy(this.gameObject);
      }
    }
}
