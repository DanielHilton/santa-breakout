using UnityEngine;

public class Paddle : MonoBehaviour
{

    float VELOCITY = 150f;

    // Use this for initialization
    void Start()
    {
        Debug.Log(transform.lossyScale.x);
        Debug.Log(transform.localScale);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var axis = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * axis * VELOCITY;
    }
}
