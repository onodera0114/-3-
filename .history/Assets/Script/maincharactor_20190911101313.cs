using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  public float speed = 1.0f;
  Vector2 inputAxis;
    // Start is called before the first frame update
    void Start()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
      rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
      inputAxis.x = Input.GetAxis("Horizontal");
      inputAxis.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate() {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
      rigidbody.MovePosition(rigidbody.position + inputAxis * speed);
    }
}
