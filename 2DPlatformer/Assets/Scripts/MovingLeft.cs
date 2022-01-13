
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    
    public float speed=1;
    public Enemy enemy;
   
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed,Space.World);
        if (transform.position.x < -10)
        {
            transform.position += Vector3.right * 22;
            randomSprite();
            enemy?.respawn();
          
        }
    }
    private void randomSprite()
    {
        int index = UnityEngine.Random.Range(0, 7);
        
            int counterForchildren = transform.childCount;
            for (int i = 0; i < counterForchildren; i++)
            {
                Transform child = transform.GetChild(i);
                child.gameObject.SetActive(index == i);

            }
       

    }
    private void OnEnable()
    {
        randomSprite();  

    }
    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }
    

}
