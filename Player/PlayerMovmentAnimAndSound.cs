using UnityEngine;
using System.Collections;

public class PlayerMovmentAnimAndSound : MonoBehaviour {
	float timeLeft,startTime;
	private CharacterController playerController;
	private Animator playerAnim;
	public AudioSource playerWalkingSound;
	void Start()
	{
		playerController = GetComponentInParent<CharacterController> ();
		playerAnim = GetComponent<Animator> ();
	}

	void Update()
	{
		if (playerController.velocity.magnitude > 1){
						playerAnim.SetBool ("PLayerMoving",true);
						//playerWalkingSound.Stop();
			}

	    else 
	{
			playerAnim.SetBool("PLayerMoving",false);
			if(!playerWalkingSound.isPlaying){
			playerWalkingSound.Play ();
			}
	}
}
}