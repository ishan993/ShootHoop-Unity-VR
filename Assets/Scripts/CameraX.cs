using UnityEngine;
using System.Collections;

public class CameraX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float RotationSpeed = 4.0f;
		float mouseX = Input.GetAxis ("Mouse X")*RotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y")*RotationSpeed;
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;
		Camera camChild = GetComponentInChildren<Camera> ();
		camChild.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camChild.transform.localRotation;
	}
}
