using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 50.0f;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
        //transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);
    }
}