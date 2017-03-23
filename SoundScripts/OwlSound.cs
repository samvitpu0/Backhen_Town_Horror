using UnityEngine;
using System.Collections;

public class OwlSound : MonoBehaviour {
	AudioSource owlSound;
	float endTime;
	// Use this for initialization
	void Start () {
		owlSound = GetComponent<AudioSource> ();
		endTime = Time.time + 51;
	}
	
	// Update is called once per frame
	void Update () {
		float timeLeft = endTime - Time.time;
			if (timeLeft < 0) {
			owlSound.Play();
			endTime= Time.time + 51;
		}
	
	}
}
