using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreEditor : MonoBehaviour {
	CentralScoreKeeper csx;
	Text text;
	// Use this for initialization
	void Start () {
		csx = FindObjectOfType<CentralScoreKeeper> ();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text="Score: " + csx.score ;
	}
}
