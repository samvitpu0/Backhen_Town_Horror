using UnityEngine;  
using System.Collections;  
   
public class Vision : MonoBehaviour   
{  
    //create a variable to access the JavaScript script  
  public GameObject myEnemy;
  private ai script;
	
	
   void OnTriggerEnter(Collider other)
 {
		
		if(other.gameObject.name == "Player")
		{
		Debug.Log ("Working");
			Awake1 ();
		
		}
 }
	
	void Awake1()
	{
		
		script = myEnemy.GetComponent<ai>();
		script.enabled = true;
	}
   
}  