using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
  Rigidbody2D rigidbody;
  GameObject Object;
  private SpriteRenderer sr = null;
  private int HP = 30;
  private float deltaTime = 0;
  private Vector3 StartPos;
  BossBall bossball;
  void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      sr = GetComponent<SpriteRenderer>();
      HP = 30;
      bossball = GetComponent<BossBall> ();
      StartPos = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        bossball = GetComponent<BossBall> ();
         if (sr.isVisible)
         {
           if(deltaTime > 100.0f){
             for (int i = 0; i < transform.childCount; i++) {
               Transform shotPosition = transform.GetChild(i);
               bossball.Shot (shotPosition);
               }
            yield return new WaitForSeconds (bossball.shotDelay);
             deltaTime = 0;
             }
         }
         else{
           if(deltaTime > 100.0f){
             deltaTime = 0;
             }
         }
        deltaTime++;
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
        HP -= 15;
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
      GetComponent<Boss>().enabled = false;

      yield return new WaitForSeconds(10f);
      rigidbody.position = StartPos;
      HP = 30;

      GetComponent<Boss>().enabled = true;
      GetComponent<CapsuleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
