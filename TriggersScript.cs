using UnityEngine;
using System.Collections;

public class TriggersScript : MonoBehaviour {

	public GameObject Dummy;

	void Start()
	{
		Dummy.SetActive (false);
	}
	void OnTriggerEnter()
	{
		Dummy.SetActive (true);
	}
}
