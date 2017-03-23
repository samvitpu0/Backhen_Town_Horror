using UnityEngine;
using System.Collections;

public class Collectable3 : MonoBehaviour {


	
	void OnTriggerEnter()
	{
		PLayerScore.playerScore++;
		GameObject.Destroy (this.gameObject);
	}
}
