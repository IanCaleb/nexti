using UnityEngine;

public class Aplle : MonoBehaviour

   
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>(); 
    }

    void OnTriggerEnter2D(Collider2D collider)//comentario de teste
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false; 
            collected.SetActive(true);

            Destroy(gameObject, 0.3f);
        }
    }
}
