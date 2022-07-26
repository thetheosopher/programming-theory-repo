using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenZMover : BaseShape
{
    public override void ColorIt()
    {
        var renderer = gameObject.GetComponent<MeshRenderer>();
        renderer.material.color = Color.green;
    }

    public override void MoveIt()
    {
        float movement = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        position.z += movement * Time.deltaTime * speed;
        transform.position = position;
    }
}
