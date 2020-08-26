using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy5_2 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private SpriteRenderer sr = null;
    private int HP = 20;
    private GameObject hero;
    private Vector2 StartPos;
    private float speed = 0.6f;
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      sr = GetComponent<SpriteRenderer>();
      HP = 20;
      StartPos = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      hero = GameObject.Find ("hero");
      if (sr.isVisible){
        Vector3 diff = (hero.transform.position - transform.position);
        rigidbody.velocity = new Vector3(diff.x * speed, diff.y * speed);
      }
      else{
        rigidbody.velocity = new Vector3(0, 0);
      }
    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        HP -= 10;
        if(HP <= 0){
          StartCoroutine ("Respawn");
        }
        else{
          StartCoroutine ("Blink");
        }
      }

      if(other.gameObject.tag == "MasterSword"){
        HP -= 30;
        if(HP <= 0){
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
      GetComponent<CapsuleCollider2D>().enabled = false;
      GetComponent<enemy5_2>().enabled = false;

      yield return new WaitForSeconds(10f);
      rigidbody.position = StartPos;
      HP = 20;

      GetComponent<enemy5_2>().enabled = true;
      GetComponent<CapsuleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
