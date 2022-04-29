using UnityEngine;

public class OnCollisionEnter : MonoBehaviour {

public PlayerMovment Movement;

void OnCollisionEnter (Collision collisioninfo)
{  
   if (collisioninfo.collider.tag == "Obstacle")
    {
       Movement.enabled = false;
    }
}
}
