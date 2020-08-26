using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private SpriteRenderer sr = null;
    private int HP = 20;
    private GameObject hero;
    private float speed = 0.6f;
    void Start()
    {
      sr = GetComponent<SpriteRenderer>();
      HP = 20;
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
          Destroy(this.gameObject);
        }
        StartCoroutine ("Blink");
      }

      if(other.gameObject.tag == "MasterSword"){
        HP -= 15;
        if(HP <= 0){
          Destroy(this.gameObject);
        }
        StartCoroutine ("Blink");
      }
    }

    IEnumerator Blink() {
      var renderComponent = GetComponent<Renderer>();
      renderComponent.enabled = !renderComponent.enabled;
      yield return new WaitForSeconds(0.1f);
      renderComponent.enabled = !renderComponent.enabled;
    }
}
