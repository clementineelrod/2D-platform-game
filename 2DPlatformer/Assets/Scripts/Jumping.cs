
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public Vector2 jumpVal;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            GetComponent<Rigidbody2D>().AddForce(jumpVal);
            GetComponent<AudioSource>().Play();
        }
    }
}
