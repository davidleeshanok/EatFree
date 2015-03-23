using UnityEngine;
using System.Collections;

public class PlayerClamp : MonoBehaviour
{

    public float leftClamp = -6;
    public float rightClamp = 6;
    public float topClamp = 6;
    public float bottomClamp = -4;
    
    // Update is called once per frame
    void Update()
    {
    
        if (rigidbody.position.x <= leftClamp || rigidbody.position.x >= rightClamp)
        {
            Vector3 pos = rigidbody.position;
            pos.x = Mathf.Clamp(pos.x, leftClamp, rightClamp);
            rigidbody.position = pos;

        }

        if (rigidbody.position.y <= bottomClamp || rigidbody.position.y >= topClamp)
        {
            Vector3 pos = rigidbody.position;
            pos.y = Mathf.Clamp(pos.y, bottomClamp, topClamp);
            rigidbody.position = pos;
        }

    }
}
