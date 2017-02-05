using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimeEditor : MonoBehaviour {
	Text  text;
	LevelManager LVM;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		LVM = FindObjectOfType<LevelManager> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Time Remaining: "+(int)LVM.levelTime;

	}
}