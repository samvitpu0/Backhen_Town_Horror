using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	float endTime;
	// Use this for initialization
	void Start () {
		endTime =4f;
	}
	
	// Update is called once per frame
	void Update () {
		float timeLeft = endTime - Time.timeSinceLevelLoad;
		if (timeLeft < 0) {
			Application.LoadLevel(1);
		}
		
	}
}

