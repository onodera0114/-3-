using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall1 : MonoBehaviour
{
      Rigidbody2D rigidbody;
    private float speed = 10f;
    private float deltaTime = 0;
    GameObject Boss;
    Boss boss;
    private float angle = 0;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      Boss = GameObject.Find ("Boss");
      boss = Boss.GetComponent<Boss>();


    }

    // Update is called once per frame
    void Update()
    {
      angle = boss.theta - 90;
      rigidbody.velocity = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad) * speed, Mathf.Sin(angle * Mathf.Deg2Rad) * speed);
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
