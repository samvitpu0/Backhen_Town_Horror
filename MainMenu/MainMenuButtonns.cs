using UnityEngine;
using System.Collections;

public class MainMenuButtonns : MonoBehaviour {

public void onStartClick()
	{
		Application.LoadLevel(3);
	}
	public void onExitClick()
	{
		Application.Quit ();
	}
	public void onCreditsClick()
	{
		Application.LoadLevel (2);
	}
}
