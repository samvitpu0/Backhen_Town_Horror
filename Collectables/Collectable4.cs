using UnityEngine;
using System.Collections;

public class Collectable4 : MonoBehaviour {

	public AudioSource radioFeed;
	public Light radioLight;
	
	void OnTriggerEnter()
	{
		radioFeed.Play ();
		radioLight.intensity = Mathf.Lerp (0f,8f,2f);
		PLayerScore.playerScore++;
		GameObject.Destroy (this.gameObject);
	}
}
