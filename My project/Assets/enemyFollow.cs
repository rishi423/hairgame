using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public Rigidbody2D followTransform;
    public Rigidbody2D enemy;
    public int speed;
    private float timer = 0;
  //  private float chase = 1f;

    void Start(){
        enemy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3){
            Vector2 direction = followTransform.position - enemy.position;
            direction = direction.normalized;
            enemy.MovePosition(enemy.position + direction * speed * Time.deltaTime);
        }
        if(followTransform.position.y < -10){
            timer = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
            if(collision.gameObject.tag == "Player"){
                timer = 0;
            }
        }
}

