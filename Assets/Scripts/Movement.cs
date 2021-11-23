using UnityEngine;

public class Movement : MonoBehaviour
{

    //controls the Rigidbody component in Unity Inspector
    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 500f;

    public float increaseFwdForce = 100f;
    public float decreaseFwdForce = -100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //control forward force in Unity Inspector
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce((forwardForce += increaseFwdForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            if(forwardForce > 0)    
                rb.AddForce((forwardForce += decreaseFwdForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
