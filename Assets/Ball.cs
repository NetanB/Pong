using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Ball : MonoBehaviour
{

    

    public Rigidbody2D rb;
    public float startingSpeed = 200.0f;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        ResetPosition();
        
    }
    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.startingSpeed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetPosition()
    {
        rb.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
        AddStartingForce();
    }
}
