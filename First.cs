using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{

    private float delta = 0;
    private bool boo = false;

    private void Update()
    {

        if (this.delta > 0.1)
            boo = true;
        else if (this.delta < 0)
            boo = false;

        if (boo)
        {
            transform.localScale += new Vector3(0.03f, 0.03f, 0);
            this.delta -= Time.deltaTime;
        }
        else
        {
            transform.localScale += new Vector3(-0.03f, -0.03f, 0);
            this.delta += Time.deltaTime;
        }
    }
}
