using UnityEngine;
using System.Collections;

public class ShootMachenim : MonoBehaviour {

	public ParticleSystem particlePosition;
	public AudioSource GunShot;
	public Transform playerPosition;
	private RaycastHit hit;
	private Ray ray;
	// Use this for initialization
	void Start () {

	}
	
	// When Fire btton is pressed
	public void onShoot()
	{
		ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width * 0.5f, Screen.height * 0.5f, 0f));
		 if (Physics.Raycast (ray, out hit, 1000f)) {
			particlePosition.transform.position=hit.point;
			particlePosition.Play();
			if(hit.collider.gameObject==GameObject.FindGameObjectWithTag("Enemy"))

				GameObject.FindGameObjectWithTag("Enemy").SendMessage("enemyHit",SendMessageOptions.DontRequireReceiver);
				}
		GunShot.Play ();
	}

}
