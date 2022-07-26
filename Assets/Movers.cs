using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movers : MonoBehaviour
{
    public List<BaseShape> movers;

    // Start is called before the first frame update
    void Start()
    {
        foreach(BaseShape mover in movers)
        {
            mover.ColorIt();
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (BaseShape mover in movers)
        {
            mover.MoveIt();
        }
    }
}
