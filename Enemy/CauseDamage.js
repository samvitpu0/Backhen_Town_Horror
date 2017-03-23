var TheDamage : int  = 50 ;

function OnCollisionEnter (theCollision :Collision)
{
    
         if(theCollision.gameObject.name == "Player")
         {   
                 Debug.Log("Burning");
             theCollision.transform.SendMessage("ApplyDamage",TheDamage,SendMessageOptions.DontRequireReceiver);        
       
          }
     
    

}