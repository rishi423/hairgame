using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    bool onGround = true;
    public int jumpHeight;
    public int dashFactor;
    public int velocityFac;
    private float timer = 0;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") / velocityFac, Space.World);
        //transform.Translate(Vector2.up * Input.GetAxis("Vertical")/50);
        if(Input.GetButtonDown("Jump") && onGround == true){
          rb.AddForce(new Vector2(Input.GetAxis("Horizontal")/(2 * velocityFac),jumpHeight),ForceMode2D.Impulse);
            onGround = false;
        }
        else if(Input.GetButtonDown("Fire2") && timer > 2){
            transform.Translate(Vector2.right * dashFactor);
          //rb.AddForce(new Vector2(dashFactor,0),ForceMode2D.Impulse);
          timer = 0;
        }

    }
    void OnCollisionEnter2D(Collision2D collision){
            onGround = true;
        }
    
}