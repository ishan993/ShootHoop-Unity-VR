using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {
	public float levelTime=60.0f; 
	public bool TimerEnabled =false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public	void Update () {
		if (TimerEnabled) {
			if (levelTime > 0) {

				levelTime -= Time.deltaTime;
			} else {
				clicked ();
			}
		}
	}
	public void clicked(){
			int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);

	}
	public void PLayAgain(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}
	}

