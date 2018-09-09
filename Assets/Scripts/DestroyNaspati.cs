using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyNaspati : MonoBehaviour {

    GameObject Fruit;
    public Text scoretext;
    int Score = 0;

    void FixedUpdate()
    {
        Fruit = GameObject.FindGameObjectWithTag("Naspati");
        Collision2D col = Fruit.GetComponent<Collision2D>();
        OnCollisionEnter2D(col);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Naspati")
        {
            Destroy(collision.gameObject);
            Score++;
            UpdateScore();
        }
    }
    void UpdateScore()
    {
        scoretext.text = "Naspatis : " + Score;
    }
}
