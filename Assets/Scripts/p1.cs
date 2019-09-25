using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    bool rotate = false;

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
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
        float sc = 22.5f * val;
        transform.localScale = new Vector3(sc, sc, sc);
    }
}
