using UnityEngine;
using System.Collections;

public class SkierLogic : MonoBehaviour {

    public int skierSpeed = 1;
	
	// Update is called once per frame
	void Update () {

        if ((Time.time - Globals.startTime) > 1)
            rigidbody.position += Vector3.down * skierSpeed * Time.deltaTime * ((Time.time - Globals.startTime) / 40);

        else
            rigidbody.position += Vector3.down * skierSpeed * Time.deltaTime;


        if (rigidbody.position.y < -4.5)
        {
            Globals.decrementLives();
            Destroy(rigidbody.gameObject);
        }
	}
}
