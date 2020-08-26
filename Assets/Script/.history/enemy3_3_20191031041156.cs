using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3_3 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public GameObject ball;
    GameObject Object;
    private SpriteRenderer sr = null;
    private int HP = 30;
    private float deltaTime = 0;
    void Start()
    {
      sr = GetComponent<SpriteRenderer>();
      HP = 30;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();
         if (sr.isVisible)
         {
           if(deltaTime > 100.0f){
             Object = Instantiate(ball, new Vector2(transform.position.x, transform.position.y - 1.0f), Quaternion.Euler(0, 0, 0));
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

