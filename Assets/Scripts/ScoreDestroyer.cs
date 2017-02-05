using UnityEngine;
using System.Collections;

public class ScoreDestroyer : MonoBehaviour {
	CentralScoreKeeper CSK;
	public int Score;
	// Use this for initialization
	void Start () {
		CSK = FindObjectOfType<CentralScoreKeeper> ();
		Score = CSK.score;
		Destroy (CSK.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		print (Score);
	}
}
