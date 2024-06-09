using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce=1.0f;
    private bool canJump=false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump){
            rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }     
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")){
            canJump = true;
        }
        if(other.gameObject.CompareTag("Spike")){
            Destroy(gameObject);
        }
    }
}
