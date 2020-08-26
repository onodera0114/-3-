using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  private Animator anime = null;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

      if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow)){
        anime.SetBool("up_move", false);
      }
      if(Input.GetKey(KeyCode.UpArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y + 0.2f, 0);
          anime.SetBool("up_move", true);
      }

      if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
        anime.SetBool("down_move", false);
      }
      if(Input.GetKey(KeyCode.DownArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - 0.2f, 0);
          anime.SetBool("down_move", true);
      }

      if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
        anime.SetBool("right_move", false);
      }
      if(Input.GetKey(KeyCode.RightArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x + 0.2f, rigidbody.position.y, 0);
          anime.SetBool("right_move", true);
      }

      if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){
        anime.SetBool("left_move", false);
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x - 0.2f, rigidbody.position.y, 0);
          anime.SetBool("left_move", true);
      }
    }
}
