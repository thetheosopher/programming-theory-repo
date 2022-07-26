using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShape : MonoBehaviour
{
    public float speed = 10;

    abstract public void ColorIt();

    abstract public void MoveIt();
}
