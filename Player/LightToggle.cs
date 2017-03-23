using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightToggle : MonoBehaviour {
	bool isLightOn;
	Button lightButton;
	AudioSource onOffToggle;
	public GameObject playerLight;
	public GameObject playerLightSound;
	public float toggleSpeed=2;
	public float playerLightIntensity=1.8f;

	// Use this for initialization
	void Start()
	{

		lightButton = GetComponent<Button> ();
		onOffToggle = playerLightSound.GetComponent<AudioSource> ();
		isLightOn=true;

	}
	public void lightToggle()
	{
		if (isLightOn) {
			
			playerLight.GetComponent<Light>().intensity=Mathf.Lerp(playerLightIntensity,0.0f,Time.deltaTime*toggleSpeed);
			isLightOn = false;
			onOffToggle.Play();
			
		} else {
			playerLight.GetComponent<Light>().intensity=Mathf.Lerp(0.0f,playerLightIntensity,Time.deltaTime*toggleSpeed);
			isLightOn=true;
			onOffToggle.Play();
		}
}
}
