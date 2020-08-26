 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
  [SerializeField]
  float speed = 5.0f;
  private Rigidbody2D rigidbody;
  private Vector2 inputAxis;
  private Vector2 Axis;
  public bool attack = true;
  private GameObject Sword;

  string dir;
  GameObject Object;
    void Start()
    {
      this.rigidbody = GetComponent<Rigidbody2D>();
      Sword = (GameObject)Resources.Load ("sword");
    }

    void Update()
    {
      inputAxis.x = Input.GetAxis("Horizontal");
      inputAxis.y = Input.GetAxis("Vertical");

      if(inputAxis. x != 0 || inputAxis.y != 0){
        Axis = inputAxis;
        if(Axis.y > 0){
          dir = "Up";
        }
       else if(Axis.y < 0){
          dir = "Down";
        }
        else if(Axis.x > 0){
          dir = "Right";
        }
        else if(Axis.x < 0){
          dir = "Left";
        }
      }

      if(Input.GetKeyDown(KeyCode.Space) && attack == true){
        switch(dir){
          case "Up":
            Object = Instantiate(Sword, new Vector2(transform.position.x - 0.8f, transform.position.y + 0.6f), Quaternion.Euler(0, 0, 190));
            Object.transform.parent = transform;
            break;
          case "Down":
            Object = Instantiate(Sword, new Vector2(transform.position.x + 0.8f, transform.position.y - 0.6f), Quaternion.Euler(0, 0, 10));
            Object.transform.parent = transform;
            break;
          case "Right":
            Object = Instantiate(Sword, new Vector2(transform.position.x + 0.7f, transform.position.y + 0.7f), Quaternion.Euler(0, 0, 100));
            Object.transform.parent = transform;
            break;
          case "Left":
            Object = Instantiate(Sword, new Vector2(transform.position.x - 0.7f, transform.position.y - 0.7f), Quaternion.Euler(0, 0, 280));
            Object.transform.parent = transform;
            break;
          default:
          break;
        }

        /*if(Axis.y < 0){
            Object = Instantiate(Sword, new Vector2(transform.position.x + 0.8f, transform.position.y - 0.6f), Quaternion.Euler(0, 0, 10));
            Object.transform.parent = transform;
        }
        else if(Axis.y > 0){
          Object = Instantiate(Sword, new Vector2(transform.position.x - 0.8f, transform.position.y + 0.6f), Quaternion.Euler(0, 0, 190));
          Object.transform.parent = transform;
        }
        else if(Axis.x > 0){
          Object = Instantiate(Sword, new Vector2(transform.position.x + 0.6f, transform.position.y + 0.8f), Quaternion.Euler(0, 0, 100));
          Object.transform.parent = transform;
        }
        else if(Axis.x < 0){
          Object = Instantiate(Sword, new Vector2(transform.position.x - 0.6f, transform.position.y - 0.8f), Quaternion.Euler(0, 0, 280));
          Object.transform.parent = transform;
        }
      }

        /* Object = Instantiate(Sword, new Vector2(transform.position.x - 0.8f, transform.position.y + 0.6f), Quaternion.Euler(0, 0, 190));
        Object.transform.parent = transform;
        Object = Instantiate(Sword, new Vector2(transform.position.x - 0.6f, transform.position.y - 0.8f), Quaternion.Euler(0, 0, 280));
        Object.transform.parent = transform;
        Object = Instantiate(Sword, new Vector2(transform.position.x + 0.6f, transform.position.y + 0.8f), Quaternion.Euler(0, 0, 100));
        Object.transform.parent = transform;*/
        }
    }

    private void FixedUpdate() {
      if(Input.GetKey(KeyCode.Z)){
          speed = 10.0f;
        }
        else{
          speed = 5.0f;
        }
      rigidbody.velocity = inputAxis.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag == "TakaraBako"){
        Sword = (GameObject)Resources.Load ("MasterSword");
        Destroy(other.gameObject);
      }
      if(other.gameObject.tag == "enemy"){
        FindObjectOfType<HP>().Damage(5);
      }
    }
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "enemyball"){
        FindObjectOfType<HP>().Damage(5);
      }
    }
    private void OnCollisionStay2D(Collision2D other) {
      if(other.gameObject.tag == "enemy"){
        rigidbody.AddForce(other.relativeVelocity * 500);
      }
    }
    private void OnTriggerStay2D(Collider2D other) {
      if(other.gameObject.tag == "enemyball"){
        Debug.Log(a);
      }
    }
}
