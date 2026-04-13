using UnityEngine;
using UnityEngine.InputSystem;

public class P1 : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
   
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
