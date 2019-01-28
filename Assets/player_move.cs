using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private Animator animator;
    public float Speed = 0.1f;
    public float Yrote = 5;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("スペース押された");
            animator.SetBool("jump", true);
            transform.position += transform.TransformDirection(Vector3.forward) * 0.05f;

        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Yrote = transform.eulerAngles.y + 1;
            transform.rotation = Quaternion.Euler(0, Yrote, 0);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);
            animator.SetBool("jump", false);
        
        } else if (Input.GetKey(KeyCode.LeftArrow)) { 
            Yrote = transform.eulerAngles.y - 1;
            transform.rotation = Quaternion.Euler(0, Yrote, 0); 
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);
            animator.SetBool("jump", false);

        } else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.TransformDirection(Vector3.forward) * Speed;

            animator.SetBool("walk_f", true);
            animator.SetBool("walk_b", false);
            animator.SetBool("jump", false);
        
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += transform.TransformDirection(Vector3.forward) * Speed * -0.1f;

            animator.SetBool("walk_b", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("jump", false);

        } else {
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);
            animator.SetBool("jump", false);
        }
    }
}
