
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	void Update () {
        transform.Rotate(0, 2, 0, Space.World);
	}
}
