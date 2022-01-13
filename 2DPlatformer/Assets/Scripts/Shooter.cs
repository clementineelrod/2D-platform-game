/*
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject projectilePrefab;
   
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {

            var projectile = Instantiate(projectilePrefab,
                transform.position,
                projectilePrefab.transform.rotation
         );

        }
    }
}
*/
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var projectile = Instantiate(
                projectilePrefab,
               new Vector3(projectilePrefab.transform.position.x,
                transform.position.y, 0),
                projectilePrefab.transform.rotation);

        }
    }
}

