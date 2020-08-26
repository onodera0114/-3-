using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
  Rigidbody2D rigidbody;
  int rand;
  int i = 1;
  private int HP = 30;
  private float deltaTime = 0f;
  private float x = 0;
  private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
      HP = 30;
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      if(deltaTime <= 50f){
        if(i == 1){
          rand = Random.Range(1, 4 + 1);

          switch(rand){
            case 1:
              x = 0.02f;
              y = 0f;
              break;
            case 2:
              x = -0.02f;
              y = 0f;
              break;
            case 3:
              x = 0f;
              y = 0.02f;
              break;
            case 4:
              x = 0f;
              y = -0.02f;
              break;
          }
          i++;
        }
        rigidbody.position = new Vector2(rigidbody.position.x + x, rigidbody.position.y + y);
      }
      else if(deltaTime >= 300f){
        deltaTime = 0;
        i = 1;
      }
      deltaTime++;
      /*if(deltaTime > 200f){
        rand = Random.Range(1, 4 + 1);

        switch(rand){
          case 1:
             while(i <= 100){
               rigidbody.position = new Vector2(rigidbody.position.x + 0.1f, rigidbody.position.y);
               i++;
             }
             break;
          case 2:
          while(i <= 100){
               rigidbody.position = new Vector2(rigidbody.position.x - 0.1f, rigidbody.position.y);
               i++;
             }
             break;
          case 3:
          while(i <= 100){
               rigidbody.position = new Vector2(rigidbody.position.x, rigidbody.position.y+0.1f);
               i++;
             }
             break;
          case 4:
          while(i <= 100){
               rigidbody.position = new Vector2(rigidbody.position.x, rigidbody.position.y - 0.1f);
               i++;
             }
             break;
        }
        i = 0;
        deltaTime = 0;
    */

    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        HP -= 10;
        if(HP <= 0){
          Destroy(this.gameObject);
        }
        rigidbody.AddForce(other.relativeVelocity * 750);
      }
    }
}
