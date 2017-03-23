using UnityEngine;
using System.Collections;

public class Thunder : MonoBehaviour {
	public Animator lightAnim;
	float endTime;
	// Use this for initialization
	void Start () {
		lightAnim=GetComponent<Animator>();
		endTime = 5;
	}
	
	// Update is called once per frame
	void Update () {
		float timeLeft = endTime - Time.time;
		if (timeLeft < 0) {
			endTime = 5 + Time.time;
			lightAnim.SetTrigger ("makeThunder");
		} else {
			lightAnim.ResetTrigger("makeThunder");
		}
		
	}
	
	}
