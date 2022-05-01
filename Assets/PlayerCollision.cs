using UnityEngine;

public class PlayerCollision : MonoBehaviour {

   public PlayerMovment movement; 

   void OnCollisionEnter (Collision collisioninfo)
   {
       if (collisioninfo.collider.tag == "Obstacle")
      {
          movement.enabled = false;
      }
   }

}
