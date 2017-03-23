using UnityEngine;
using System.Collections;

public class Collectable1 : MonoBehaviour {

	void OnTriggerEnter()
	{
		PLayerScore.playerScore++;
		GameObject.Destroy (this.gameObject);
	}
}
