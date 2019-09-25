using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chips : MonoBehaviour
{
    bool rotate = false;

    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * 30));
        }
    }

    public void ptrDown()
    {
        rotate = true;
    }

    public void ptrUp()
    {
        rotate = false;
    }

    public void OnValueChanged(float val)
    {
        float sc = 45f * val;
        transform.localScale = new Vector3(sc, sc, sc);
    }

    public void c1()
    {
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);

        t1.SetActive(true);
    }

    public void c2()
    {
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);

        t2.SetActive(true);
    }

    public void c3()
    {
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);

        t3.SetActive(true);
    }

    public void c4()
    {
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);

        t4.SetActive(true);
    }
}
