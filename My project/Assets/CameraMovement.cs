using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Rigidbody2D Player;
    public int velocityFac;
    void LateUpdate()
    {

           // transform.Translate(Vector2.right * Input.GetAxis("Horizontal") / velocityFac, Space.World);
    }
}
