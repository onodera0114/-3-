using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactor : MonoBehaviour
{
  Animator animetor;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);
        this.animetor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

      if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.UpArrow)){
        animetor.SetBool("up_move", false);
        animetor.SetBool("move", true);
      }
      if(Input.GetKey(KeyCode.UpArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y + 0.2f, 0);
          animetor.SetBool("up_move", true);
          animetor.SetBool("move", false);
      }

      if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
        animetor.SetBool("down_move", false);
        animetor.SetBool("move", true);
      }
      if(Input.GetKey(KeyCode.DownArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - 0.2f, 0);
          animetor.SetBool("down_move", true);
          animetor.SetBool("move", false);
      }

      if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
        animetor.SetBool("right_move", false);
        animetor.SetBool("move", true);
      }
      if(Input.GetKey(KeyCode.RightArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x + 0.2f, rigidbody.position.y, 0);
          animetor.SetBool("right_move", true);
          animetor.SetBool("move", false);
      }

      if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){
        animetor.SetBool("left_move", false);
        animetor.SetBool("move", true);
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
          rigidbody.position = new Vector3(rigidbody.position.x - 0.2f, rigidbody.position.y, 0);
          animetor.SetBool("left_move", true);
          animetor.SetBool("move", false);
      }
    }
}
