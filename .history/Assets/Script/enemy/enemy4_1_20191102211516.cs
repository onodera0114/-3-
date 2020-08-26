using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4_1 : MonoBehaviour
{
  private Rigidbody2D rigidbody;
  int rand;
  private Vector2 StartPos;
  int i = 1;
  private int HP = 30;
  private float deltaTime = 0f;
  private float x = 0;
  private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      HP = 30;
      StartPos = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      rigidbody.velocity = new Vector2(0, 0);
      if(deltaTime <= 35f){
        if(i == 1){
          rand = Random.Range(1, 4 + 1);

          switch(rand){
            case 1:
              x = 0.05f;
              y = 0f;
              break;
            case 2:
              x = -0.05f;
              y = 0f;
              break;
            case 3:
              x = 0f;
              y = 0.05f;
              break;
            case 4:
              x = 0f;
              y = -0.05f;
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

    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        HP -= 10;
        if(HP <= 0){
          FindObjectOfType<Score>().AddPoint(225);
          StartCoroutine ("Respawn");
        }
        else{
          StartCoroutine ("Blink");
        }
      }

      if(other.gameObject.tag == "MasterSword"){
        HP -= 30;
        if(HP <= 0){
          FindObjectOfType<Score>().AddPoint(225);
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
      GetComponent<enemy4_1>().enabled = false;

      yield return new WaitForSeconds(45f);
      rigidbody.position = StartPos;
      HP = 30;

      GetComponent<enemy4_1>().enabled = true;
      GetComponent<CapsuleCollider2D>().enabled = true;
      renderComponent.enabled = true;
    }
}
