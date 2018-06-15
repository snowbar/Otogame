using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour {

    private float delta=0;

	private void Update () {
        this.delta += Time.deltaTime;

        if (this.delta < 0.7)
        {
            transform.Translate(0, -0.2f, 0);
            transform.localScale += new Vector3(0.013f,0.013f,0);
        }
        else
            transform.Translate(0, -0.2f, 0);
        if (this.transform.position.y < -7.0)
        { 
            Destroy(gameObject);
            GameObject.Find("Image").GetComponent<Image>().fillAmount -= 0.1f;
        }
	}
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Destroy(gameObject);
        GameObject.Find("Kantoku").GetComponent<Kantoku>().Score();
    }

}
