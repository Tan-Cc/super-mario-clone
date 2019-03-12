
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallRotate : MonoBehaviour {

	void Update () {
        transform.Rotate(0, 0, -1, Space.World);
	}
}
