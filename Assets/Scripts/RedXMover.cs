using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedXMover : BaseShape
{
    public override void ColorIt()
    {
        var renderer = gameObject.GetComponent<MeshRenderer>();
        renderer.material.color = Color.red;
    }

    public override void MoveIt()
    {
        float movement = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        position.x += movement * Time.deltaTime * speed;
        transform.position = position;
    }
}
