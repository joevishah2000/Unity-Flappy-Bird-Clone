using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Text scoreText;
    public float score;

    private Rigidbody2D rb;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpforce);
        }
        
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag=="pipe")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void UpdateScore()
    {
        score = score + 0.5f;
        scoreText.text = score.ToString();
    }
}
