using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {

    public GameObject area;
    private readonly float a = 6.5f;
    private readonly float b = 3.35f;

    public void Push(){
        GameObject areas = Instantiate(area) as GameObject;
        areas.transform.position = new Vector3(-a, -b, 0);
        GameObject.Find("LeftButton").GetComponent<AudioSource>().Play();
        StartCoroutine(DelayMethod(5, () =>
         {
             Destroy(areas);
         }));
       
    }
    public void Push1()
    {
        GameObject areas = Instantiate(area) as GameObject;
        areas.transform.position = new Vector3(-a/2, -b, 0);
        GameObject.Find("LeftButton1").GetComponent<AudioSource>().Play();
        StartCoroutine(DelayMethod(5, () =>
        {
            Destroy(areas);
        }));
        
    }
    public void Push2()
    {
        GameObject areas = Instantiate(area) as GameObject;
        areas.transform.position = new Vector3(0, -b, 0);
        GameObject.Find("LeftButton2").GetComponent<AudioSource>().Play();
        StartCoroutine(DelayMethod(5, () =>
        {
            Destroy(areas);
        }));
       
    }
    public void Push3()
    {
        GameObject areas = Instantiate(area) as GameObject;
        areas.transform.position = new Vector3(a/2, -b, 0);
        GameObject.Find("LeftButton3").GetComponent<AudioSource>().Play();
        StartCoroutine(DelayMethod(5, () =>
        {
            Destroy(areas);
        }));
        
    }
    public void Push4()
    {
        GameObject areas = Instantiate(area) as GameObject;
        areas.transform.position = new Vector3(a, -b, 0);
        GameObject.Find("LeftButton4").GetComponent<AudioSource>().Play();
        StartCoroutine(DelayMethod(5, () =>
        {
            Destroy(areas);
        }));
       
    }
    private IEnumerator DelayMethod(int delayFrameCount, Action action)
    {
        for (var i = 0; i < delayFrameCount; i++)
        {
            yield return null;
        }
        action();
    }
}
