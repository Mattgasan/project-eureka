using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Mathf.Abs(horizontal) < 0.1f) horizontal = 0;
        if (Mathf.Abs(vertical) < 0.1f) vertical = 0;
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
