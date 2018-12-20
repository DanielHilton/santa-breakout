using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{

    private Dictionary<int, Color> healthColours = new Dictionary<int, Color> {
        {1, Color.red},
        {2, Color.blue},
        {3, Color.green},
        {4, Color.yellow}
    };

    public int health = 1;


    private void Start()
    {
        GetComponent<SpriteRenderer>().color = GetColourForHealth();
    }

    private Color GetColourForHealth()
    {
        Color hCol;
        healthColours.TryGetValue(health, out hCol);
        return hCol;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("blockhit_audio").GetComponent<AudioSource>().Play();
        health--;

        if (health == 0)
        {
            GetComponent<ParticleSystem>().Play();
            Globals.BlockCount--;
            Destroy(gameObject);

            if(Globals.BlockCount == 0){
                SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
            }
            return;
        }



        GetComponent<SpriteRenderer>().color = GetColourForHealth();
    }
}
