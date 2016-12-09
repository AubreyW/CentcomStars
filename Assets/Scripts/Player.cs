using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float RotationSpeed;
    public float ShipSpeed;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate() //Repeate every set amount of time (Use this instead of update for performance)
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().angularVelocity = RotationSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().angularVelocity = -RotationSpeed;
        }
        else
        {
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 forceVector = transform.up * ShipSpeed;
            GetComponent<Rigidbody2D>().AddForce(forceVector);

            anim.SetBool("Moving", true);

            print("Moving");
        }
        else
        {
            anim.SetBool("Moving", false);

            print("Not Moving");
        }


    }
}
