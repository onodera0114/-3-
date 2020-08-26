﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1_3 : MonoBehaviour
{
  Rigidbody2D rigidbody;
  public GameObject ball;
  GameObject Object;
  private SpriteRenderer sr = null;
  private int HP = 30;
  private float deltaTime = 0;
  private Vector3 StartPos;
  void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      sr = GetComponent<SpriteRenderer>();
      HP = 30;
      StartPos = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, 0);
         if (sr.isVisible)
         {
           if(deltaTime > 250.0f){
             Object = Instantiate(ball, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
             deltaTime = 0;
             }
         }
         else{
           if(deltaTime > 250.0f){
             deltaTime = 0;
             }
         }
        deltaTime++;
    }

        private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        HP -= 10;
        if(HP <= 0){
          FindObjectOfType<Score>().AddPoint(100);
          StartCoroutine ("Respawn");
        }
        else{
          StartCoroutine ("Blink");
        }
      }

      if(other.gameObject.tag == "MasterSword"){
        HP -= 15;
        if(HP <= 0){
          FindObjectOfType<Score>().AddPoint(100);
          StartCoroutine ("Respawn");
        }
        else{
          StartCoroutine ("Blink");
        }
      }
    }

     IEnumerator Blink() {
      var renderComponent = GetComponent<Renderer>();
      renderComponent.enabled = !renderComponent.enabled;
      yield return new WaitForSeconds(0.1f);
      renderComponent.enabled = !renderComponent.enabled;
    }

    IEnumerator Respawn(){
      Renderer renderComponent = this.GetComponent<Renderer>();
      renderComponent.enabled = false;
      GetComponent<CircleCollider2D>().enabled = false;
      GetComponent<enemy1_3>().enabled = false;

      yield return new WaitForSeconds(45f);
      rigidbody.position = StartPos;
      HP = 30;

      GetComponent<enemy1_3>().enabled = true;
      GetComponent<CircleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
