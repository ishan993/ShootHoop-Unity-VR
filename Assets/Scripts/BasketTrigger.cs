using UnityEngine;
using System.Collections;

public class BasketTrigger : MonoBehaviour {
	void OnTriggerEnter(Collider collider){
		BasketTrigger2 BT2 = GetComponentInChildren<BasketTrigger2> ();
		BT2.FirstDone (collider);

	}
}
