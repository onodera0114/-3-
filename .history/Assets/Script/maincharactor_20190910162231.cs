using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

      if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow)){
        anim.SetBool("up_move", false);
      }
      if(Input.GetKey(KeyCode.UpArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y + 0.2f, 0);
          anim.SetBool("up_move", true);
      }

      if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
        anim.SetBool("down_move", false);
      }
      if(Input.GetKey(KeyCode.DownArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - 0.2f, 0);
          anim.SetBool("down_move", true);
      }

      if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
        anim.SetBool("right_move", false);
      }
      if(Input.GetKey(KeyCode.RightArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x + 0.2f, rigidbody.position.y, 0);
          anim.SetBool("right_move", true);
      }

      if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){
        anim.SetBool("left_move", false);
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x - 0.2f, rigidbody.position.y, 0);
          anim.SetBool("left_move", true);
      }
    }
}
