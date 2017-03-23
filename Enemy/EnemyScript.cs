using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int enemyHealth;


	void enemyHit()
	{
		enemyHealth -= 10;
	}

}
