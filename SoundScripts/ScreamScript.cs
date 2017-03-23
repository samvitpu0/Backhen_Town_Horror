using UnityEngine;
using System.Collections;

public class ScreamScript : MonoBehaviour {
	AudioSource WomenScream;
	void Start()
	{
		WomenScream = GetComponentInChildren<AudioSource> ();
		}
	void OnTriggerEnter(Collider other)
	{
		GameObject.Destroy (this.gameObject);
		WomenScream.Play ();
	}
}
