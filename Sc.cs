using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sc : MonoBehaviour
{
    public static int s;
    public Text scoreText;
    private void Start()
    {
        scoreText.text = "Score: " + s.ToString();
    }
    public void Push()
    {
        SceneManager.LoadScene("GameStart");
    }
}
