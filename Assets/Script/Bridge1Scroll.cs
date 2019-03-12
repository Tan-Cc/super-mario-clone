
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge1Scroll : MonoBehaviour {

    public float ResetPoint;
    public float CurrentPoint;

    private void Update()
    {
        ResetPoint = 6.99f;
        CurrentPoint = transform.position.y;

        if(CurrentPoint >= ResetPoint)
        {
            Vector3 vector = new Vector3(10.52f, -1.95f, 0.59f);
            transform.position= vector;
        }

        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
