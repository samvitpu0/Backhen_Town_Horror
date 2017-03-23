using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour {

public Transform[] waypoints;
	public float speed;
	public int curwaypoint;
	public bool dopatrol =true;
	//Vector3 target;
	public Vector3  movedirection;
	public Vector3 velocity ;
	SphereCollider PlayerTrigger;
	EnemyScript enemyFollwPlayer;

	void Start()
	{
		enemyFollwPlayer = GetComponent<EnemyScript> ();
		PlayerTrigger = GetComponent<SphereCollider> ();
	}

	void Update()
	{
		
		if(curwaypoint < waypoints.Length)
		{
			

			movedirection = waypoints[curwaypoint].position - transform.position;
			velocity = GetComponent<Rigidbody>().velocity;
			if(movedirection.magnitude < 1)
			{
				
				curwaypoint++;
			}
			else 
			{
				
				velocity = movedirection.normalized *speed;
			}
			
		}
		else 
		{
			
			  if(dopatrol)
			{
				
				curwaypoint = 0;
			}
			else 
			{
				
				velocity = Vector3.zero ;
			}
		}
		
		GetComponent<Rigidbody>().velocity =velocity ; 
		transform.LookAt(waypoints[curwaypoint].position);
	}



}

