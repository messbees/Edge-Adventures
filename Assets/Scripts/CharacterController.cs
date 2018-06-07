using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
        //transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);
    }
}