using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Kantoku : MonoBehaviour {

    GameObject hp;
    public Text scoreText;
    private int score = 0;

    // Use this for initialization
    private void Start () {
        hp = GameObject.Find("Image");
        scoreText.text = "Score: 0";
	}

    public void Score()
    {
        score++;
        if (score % 10 == 0)
        {
            if (Makenootu.span > 0.2f)
                Makenootu.span -= 0.05f;
             
        }
    }

    private void Update () {
        if (this.hp.GetComponent<Image>().fillAmount <= 0)
        {
            Sc.s = score;
            Makenootu.span = 1.0f;
            SceneManager.LoadScene("GameOver");
        }
        scoreText.text = "Score: " + score.ToString();
        
	}
}
