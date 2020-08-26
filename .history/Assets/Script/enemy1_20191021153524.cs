using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
  Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rigidbody = GetComponent<Rigidbody2D>();

      rigidbody.position = new Vector2(this.rigidbody.position.x +0.03f, this.rigidbody.position.y);
    }
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "sword"){
        Destroy(this.gameObject);
      }
    }
}
