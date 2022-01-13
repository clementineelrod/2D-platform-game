using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{
    public Vector2 startingVlocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startingVlocity;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy=collision.collider.GetComponent<Enemy>();
        enemy?.enemyDies();
        Destroy(gameObject);
    }

}
