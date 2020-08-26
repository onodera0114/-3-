using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
  Rigidbody2D rigidbody;
  private float deltaTime = 0f;
  int rand;
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
        Debug.Log(rand);
      }
      deltaTime++;


    }
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        Destroy(this.gameObject);
      }
    }
}
