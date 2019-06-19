using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


    private Rigidbody2D rb2d;



    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    float horizontalMove = 0f;
    float verticalMove = 0f;
    public float runSpeed = 100f;

    void FixedUpdate()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        verticalMove = Input.GetAxis("Vertical") * runSpeed;
        Vector2 movement = new Vector2(horizontalMove, verticalMove) * Time.fixedDeltaTime;
        rb2d.velocity = (movement);
        rb2d.freezeRotation = true;

    }

}
