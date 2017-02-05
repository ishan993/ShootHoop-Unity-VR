using UnityEngine;
using System.Collections;

public class BallInstantiator : MonoBehaviour {
	public GameObject BallInstance;
	private CardboardHead ch;
	// Use this for initialization
	void Start () {
		Cardboard.SDK.OnTrigger+= Cardboard_SDK_OnTrigger;
	}

	void Cardboard_SDK_OnTrigger ()
	{
		Camera cam = GetComponentInChildren <Camera> ();
		GameObject instance = Instantiate (BallInstance);
		instance.transform.position = transform.position;
		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		rb.velocity = cam.transform.rotation*Vector3.forward*13;

	}
	
	// Update is called once per frame
	void Update() {
		
	
		
	}
}
