using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paper1 : MonoBehaviour {
	public Text back;
	public RawImage paperimage;
	public GameObject paper;
	void OnTriggerEnter()
	{
		paperimage.color = Color.Lerp (new Color (255f, 255f, 255f, 0f), new Color (255f, 255f, 255f, 255f), 2f);
		back.color = Color.Lerp (new Color (255f, 255f, 255f, 0f), new Color (255f, 255f, 255f, 255f), 2f);
	}
	public void onBackClick()
	{
		paperimage.color = Color.Lerp (new Color (255f, 255f, 255f, 255f), new Color (255f, 255f, 255f, 0f), 2f);
		back.color = Color.Lerp (new Color (255f, 255f, 255f, 255f), new Color (255f, 255f, 255f, 0f), 2f);
		paper.gameObject.SetActive (false);
	}
}
