using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;

    public  int speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        PlayerMovement();

    }

    private void FixedUpdate()
    {
        
    }

    void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }

    void PlayerMovement()
    {
        Vector2 newVelocity = new Vector2(horizontalInput, verticalInput).normalized * speed;
        rb.velocity = newVelocity;

    }
}
