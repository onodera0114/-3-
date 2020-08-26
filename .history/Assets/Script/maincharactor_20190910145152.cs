using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  /* SpriteRenderer Main;
    public Sprite Up;
    public Sprite Down;
    public Sprite Right;
    public Sprite Left;
*/
    // Start is called before the first frame update
    void Start()
    {
        //Main = gameObject.GetComponent<SpriteRenderer>();

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
      if(Input.GetKey(KeyCode.UpArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y + 0.2f, 0);
         //Main.sprite = Up;
      }
      if(Input.GetKey(KeyCode.DownArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - 0.2f, 0);
          //Main.sprite = Down;
      }
      if(Input.GetKey(KeyCode.RightArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x + 0.2f, rigidbody.position.y, 0);
         // Main.sprite = Right;
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x - 0.2f, rigidbody.position.y, 0);
          //Main.sprite = Left;
      }
    }
}
