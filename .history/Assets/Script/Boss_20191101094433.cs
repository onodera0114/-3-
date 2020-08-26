using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
  Rigidbody2D rigidbody;
  public GameObject bossball3;
  GameObject Object;
  private SpriteRenderer sr = null;
  private int HP = 30;
  public float theta = 0;
  private float deltaTime = 0;
  private GameObject hero;
  private Vector3 StartPos;
  void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      sr = GetComponent<SpriteRenderer>();
      HP = 30;
      StartPos = rigidbody.position;
      hero = GameObject.Find ("hero");
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
         if (sr.isVisible)
         {
           if(deltaTime > 100.0f){
             theta = Mathf.Atan2(transform.position.y - hero.position.y, transform.position.x - hero.position.x);
             Object = Instantiate(bossball3, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
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
      GetComponent<CircleCollider2D>().enabled = false;
      GetComponent<enemy1_3>().enabled = false;

      yield return new WaitForSeconds(10f);
      rigidbody.position = StartPos;
      HP = 30;

      GetComponent<enemy1_3>().enabled = true;
      GetComponent<CircleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
