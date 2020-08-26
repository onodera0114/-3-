using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class maincharactor : MonoBehaviour
{
    public Vector2 lastMove;

    [SerializeField]
    private float speed;

    Rigidbody2D rigidbody;
    Animator animator;
    Vector2 movement;

    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();
      rigidbody.position = new Vector3(0.0f, 0.0f, 0.0f);

      animator = GetComponent<Animetor>();
    }

    void Update(){
      movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      Animete();
    }

    private void FixedUpdate() {
      MoveHero();
    }

    public void AnimeteHero(){
      if (Mathf.Abs(movement.x) > 0.5f)
        {
            lastMove.x = movement.x;
            lastMove.y = 0;
        }
        if (Mathf.Abs(movement.y) > 0.5f)
        {
            lastMove.y = movement.y;
            lastMove.x = 0;
        }

        animator.SetFloat("Dir_X", movement.x);
        animator.SetFloat("Dir_Y", movement.y);
        animator.SetFloat("LastMove_X", lastMove.x);
        animator.SetFloat("LastMove_Y", lastMove.y);
        animator.SetFloat("Input", movement.magnitude);
    }
    public void MoveHero(){
      rigidbody.AddForce(movement.normalized * speed * 1.5f);
    }
}
