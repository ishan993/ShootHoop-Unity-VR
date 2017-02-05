using UnityEngine;
using System.Collections;

public class CentralScoreKeeper : MonoBehaviour {
	public  int  score=0;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void incrementer(int scorex){
		score += scorex;
		print ("You hit the target. Current Score: " + score);
	}

}
