
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge2move : MonoBehaviour {

    public float RightPoint = 42.33f;
    public float LeftPoint = 35.28f;
    public int Direction = 1;

    private void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            Direction = 1;
        }

        if (this.transform.position.x > RightPoint)
        {
            Direction = 2;
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }

        if (this.transform.position.x < LeftPoint)
        {
            Direction = 1;
        }
    }
}
