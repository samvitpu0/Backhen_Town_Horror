using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PLayerScore : MonoBehaviour {
	public Text playerScoreText;
	public static int playerScore;
	// Use this for initialization
	void Start () {
		playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		playerScoreText.text = "Collectables Left:" + (4-playerScore).ToString();
		if (playerScore > 4) {
			//Application.LoadLevel(3);
		}
	}
}
