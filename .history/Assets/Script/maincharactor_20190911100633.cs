using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  float speed = 1.0f;
  Vector2 inputAxis;
  Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
      inputAxis.x = Input.GetAxis("Horizontal");
      inputAxis.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate() {
      rigidbody.MovePosition(rigidbody.position + inputAxis * speed);
    }
}
