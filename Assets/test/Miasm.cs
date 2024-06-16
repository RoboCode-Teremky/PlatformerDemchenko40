using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miasm : MonoBehaviour
{
    [SerializeField] private Transform firstPoint;
    [SerializeField] private Transform secondPoint;
    private Rigidbody2D rigibdody2D;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float phase = 0.0f;    
    void Start()
    {
        rigibdody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigibdody2D.position = Vector3.Lerp(firstPoint.position,
                                            secondPoint.position,
                                            Mathf.Sin(speed*Time.fixedTime)/2+0.5f
                                            );
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            Destroy(other.gameObject);
        }
    }

}
