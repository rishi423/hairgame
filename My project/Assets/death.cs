using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public Transform enemy;
    public Transform respawn;
    public Transform enemyRespawn;
    public void die(){
        transform.position = respawn.position;
    //    transform.position.y = respawn.bounds.max.y + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10){
            die();
            enemy.position = enemyRespawn.position;
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
            if(collision.gameObject.tag == "Enemy"){
                die();
                enemy.position = enemyRespawn.position;
            }
        }
}
