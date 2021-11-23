using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement move;    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    
    }

}
