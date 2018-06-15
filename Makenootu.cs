using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makenootu : MonoBehaviour {

    public GameObject nootu;
    public static float span = 1.0f;
    private float delta = 0;
    private readonly float a = 3.25f;
    private readonly float b = 5.8f;

    private void Update () {
        this.delta += Time.deltaTime;
        if(this.delta > span)
        {
            this.delta = 0;
            if (Random.Range(0,2)==0)
            {
                Mkn(a * Random.Range(-2, 0));
                Mkn(a * Random.Range(0, 3));
            }
            else
            {
                Mkn(a*Random.Range(-2,3));
            }
        }
        
	}
    private void Mkn(float a)
    {
        GameObject fnootu = Instantiate(nootu) as GameObject;
        fnootu.transform.position = new Vector3(-a, b, 0);
    }
}
