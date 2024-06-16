using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllScript : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from new script!");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(h, v);
        transform.Translate((Vector3)inputVector*speed);
        
    }
        
    private void OnCollisionEnter2D(Collision2D other)
       {
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
        }
        }
    
        
       

}
