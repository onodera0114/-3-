using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
  Rigidbody2D rigidbody;
  private float deltaTime = 0f;
  int rand;
  int i = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();

      if(deltaTime > 100f){
        rand = Random.Range(1, 4 + 1);
        switch(rand){
          case 1:
             while(i <= 10){
               rigidbody.position = new Vector2(rigidbody.position.x + 0.1f, rigidbody.position.y);
             }
             break;
          case 2:
          while(i <= 10){
               rigidbody.position = new Vector2(rigidbody.position.x - 0.1f, rigidbody.position.y);
             }
             break;
          case 3:
          while(i <= 10){
               rigidbody.position = new Vector2(rigidbody.position.x, rigidbody.position.y+0.1f);
             }
             break;
          case 4:
          while(i <= 10){
               rigidbody.position = new Vector2(rigidbody.position.x, rigidbody.position.y - 0.1f);
             }
             break;
        }
        i = 0;
        deltaTime = 0;
      }
      deltaTime++;


    }
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        Destroy(this.gameObject);
      }
    }
}
