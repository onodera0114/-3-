using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
  Rigidbody2D rigidbody;
  public GameObject bossball1;
  public GameObject bossball2;
  public GameObject bossball3;
  public GameObject bossball4;
  public GameObject bossball5;
  GameObject Object;
  private SpriteRenderer sr = null;
  private int HP = 250;
  public float theta = 0;
  private float deltaTime = 0;
  private GameObject hero;
  private Vector3 StartPos;
  void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      sr = GetComponent<SpriteRenderer>();
      HP = 250;
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
             theta = Mathf.Atan2(- transform.position.y + hero.transform.position.y, - transform.position.x + hero.transform.position.x) * Mathf.Rad2Deg;
             Object = Instantiate(bossball1, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
             Object = Instantiate(bossball2, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
             Object = Instantiate(bossball3, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
             Object = Instantiate(bossball4, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
             Object = Instantiate(bossball5, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
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
        HP -= 20;
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
      HP = 250;

      GetComponent<Boss>().enabled = true;
      GetComponent<CapsuleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
