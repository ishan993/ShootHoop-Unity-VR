using UnityEngine;
using System.Collections;

public class BasketTrigger2 : MonoBehaviour {
	Collider placeholder;
	CentralScoreKeeper csk;
	public void FirstDone(Collider parentCollider){
		placeholder = parentCollider;
	}
	void OnTriggerEnter(Collider collider){
		if (placeholder==collider) {
			print("Detected!");
			csk = FindObjectOfType<CentralScoreKeeper> ();
			csk.incrementer (1);
		}
	}
}
