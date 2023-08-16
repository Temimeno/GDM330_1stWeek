using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]Rigidbody2D rb;
    [SerializeField]float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var moveDirection = horizontalInput * new Vector3(1, 0, 0);
        rb.AddForce(moveDirection * moveSpeed);
    }
}