using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall2 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private float speed = 0.8f;
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
      angle = boss.theta - 45;
      Debug.Log(angle);
      rigidbody.velocity = new Vector2(Mathf.Sin(angle) * speed, Mathf.Cos(angle) * speed);
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
