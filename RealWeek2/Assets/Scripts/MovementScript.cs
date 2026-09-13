using TMPro;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5f;   
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0f, v);
        transform.Translate(move * speed * Time.deltaTime, Space.Self);
        
    }
}
