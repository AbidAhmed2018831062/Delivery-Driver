using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
  [SerializeField]      float steerSpeed=0.5f;
  [SerializeField] float moveSpeed=0.01f;

  

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
      moveSpeed-=10f;
    }
    private void OnTriggerEnter2D(Collider2D other) {
      if(other.tag=="Boost")
      moveSpeed+=30f;
    }
}
