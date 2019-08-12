using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

	public Transform target;

	public Vector3 offset;

	private void LateUpdate () {
		if (target.position.x > 6) {
			Vector3 newPos = target.position + offset;
			newPos.z = transform.position.z;
			newPos.y = transform.position.y;
			transform.position = newPos;
		}
	}
}