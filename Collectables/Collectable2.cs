using UnityEngine;
using System.Collections;

public class Collectable2 : MonoBehaviour {
	

	void OnTriggerEnter()
	{
		PLayerScore.playerScore++;
		GameObject.Destroy (this.gameObject);
	}
}
