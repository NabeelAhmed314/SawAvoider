using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float moveHorizontal, moveVertical;
    public float moveSpeed=10f;
    public Rigidbody2D rb;
    Vector2 move;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        joystick = FindObjectsOfType<FixedJoystick>()[0];
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = joystick.Horizontal;
        moveVertical = joystick.Vertical;
        move = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = move * moveSpeed;
    }
}
