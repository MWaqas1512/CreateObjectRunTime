using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float LifeTime = 10f;

    // Update is called once per frame
    void Update()
    {
        if (LifeTime > 0)
        {
            LifeTime -= Time.deltaTime;
            if (LifeTime <= 0)
            {
                destruction();
            }
        }

        if (this.transform.position.y < -20)
        {
            destruction();
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "destroyer")
        {
            destruction();
        }
    }

    void destruction()
    {
        Destroy(this.gameObject);
    }
}
