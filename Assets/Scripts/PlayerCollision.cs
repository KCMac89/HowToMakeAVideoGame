
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // referencing PlayerMovement Script, drag into playerCollision script from  components menu

    void OnCollisionEnter(Collision collisionInfo) // for when objects collide
    {



        //Debug.Log("we hit something");

     // Debug.Log(collisionInfo.collider.name); // dislplays name player collides with

        if (collisionInfo.collider.tag == "Obstacle")
        {
          
            movement.enabled = false; // now the player stops when colliding with an obstacle
            FindObjectOfType<GameManager>().EndGame(); // calls endgame fn to display Game Over in the console
        }
    }




}
