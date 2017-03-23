using UnityEngine;
using System.Collections;

public class Bird1Sound : MonoBehaviour {
	AudioSource bird1Sound;
	float endTime;
	// Use this for initialization
	void Start () {
		bird1Sound = GetComponent<AudioSource> ();
		endTime = Time.time + 51;
	}
	
	// Update is called once per frame
	void Update () {
		float timeLeft = endTime - Time.time;
		if (timeLeft < 0) {
			bird1Sound.Play();
			endTime= Time.time + 51;
		}
		
	}
}
