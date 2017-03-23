#pragma strict

var Health = 20;
function Update ()
{
    if (Health <= 0)
     {
     
         Dead();
     }

}

function ApplyDamage (TheDamage: int)
 {
 
 
 Health -= TheDamage;
 }
 function Dead()
 {
     Destroy (gameObject);
  
 }