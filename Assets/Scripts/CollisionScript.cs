using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {
	public int ScoreForThisComponent = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		CentralScoreKeeper CSK = FindObjectOfType<CentralScoreKeeper> ();
		CSK.incrementer (ScoreForThisComponent); 


	}
}
