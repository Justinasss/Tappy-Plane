using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float jumpForce = 100;

    public TextMeshProUGUI scoreText;

    

    private Rigidbody2D rb;

    private int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (rb.velocity.y < 0)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            }
        }

        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        scoreText.text = (++score).ToString();
    }
}
