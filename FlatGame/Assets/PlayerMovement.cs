using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rigidbody2D;

    Vector2 movement;

    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0) {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            characterScale.x = 1;
        }

        transform.localScale = characterScale;
    }

    void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


}
