using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float Speed = 0.1f;
    public float Yrote = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            Yrote = transform.eulerAngles.y + 1;
            transform.rotation = Quaternion.Euler(0, Yrote, 0);
        
        } else if (Input.GetKey(KeyCode.LeftArrow)) { 
            Yrote = transform.eulerAngles.y - 1;
            transform.rotation = Quaternion.Euler(0, Yrote, 0); 

        } else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.TransformDirection(Vector3.forward) * Speed;
        
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += transform.TransformDirection(Vector3.forward) * Speed * -0.1f;
        }
    }
}
