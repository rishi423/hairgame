using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject respawn;
    public void die(){
        transform.position = respawn.transform.position;
    //    transform.position.y = respawn.bounds.max.y + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10){
            die();
        }
    }
}
