using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public int playerSpeed = 5;
    
    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();

        if (Input.anyKey == false)
        {
            anim.SetInteger("vertDir", 0);
            anim.SetInteger("horizDir", 0);
        }

        else 
        {

            if (Input.GetKey("up"))
            {
                rigidbody.position += Vector3.up * playerSpeed * Time.deltaTime;
                anim.SetInteger("vertDir", 1);
            } 
            else if (Input.GetKey("down"))
            {
                rigidbody.position += Vector3.down * playerSpeed * Time.deltaTime;
                 anim.SetInteger("vertDir", -1);
            }

            if (Input.GetKey("left"))
            {
                rigidbody.position += Vector3.left * playerSpeed * Time.deltaTime;
                anim.SetInteger("horizDir", -1);

            } 
            else if (Input.GetKey("right"))
            {
                rigidbody.position += Vector3.right * playerSpeed * Time.deltaTime;
                anim.SetInteger("horizDir", 1);

            }
        }
 
        rigidbody.velocity = new Vector3(0, 0, 0);    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Skier")
        {
            Destroy(other.gameObject);

            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("eating");

            Globals.incrementScore();
        }
    }
}
