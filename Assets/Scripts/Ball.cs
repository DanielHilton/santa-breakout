using Application;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    //movement speed
    public float speed;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 paddlePos, float paddleWidth) {
        return (ballPos.x - paddlePos.x) / paddleWidth;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "paddlyboi") {
            var hf = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            var dir = new Vector2(hf, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }    
    }

    private void FixedUpdate()
    {
        if(transform.position.y < -250f){
            Globals.Lives--;
            if(Globals.Lives < 1){
                SceneManager.LoadScene("GameOverScene");
            }

            var padPos = GameObject.Find("paddlyboi").transform.position;
            padPos.y += 10;
            transform.position = padPos;
        }
    }
}
