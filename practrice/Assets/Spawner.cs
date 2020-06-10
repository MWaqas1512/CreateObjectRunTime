using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Spawner : MonoBehaviour
{
    //public Transform spawnPos;
    //public GameObject spawnee;
    public GameObject theObject;
    public float maxPos= 200f;
    public float minPos = 200f;

    public void spawn() {
        
            
            var theNewPos= new Vector3 (Random.Range(minPos,maxPos),0,Random.Range(minPos,maxPos));
            GameObject go = Instantiate(theObject);
            go.transform.position = theNewPos;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
            if (Input.GetButtonDown("createBall"))
            {
                spawn();
                //Instantiate(spawnee,spawnPos.position,spawnPos.rotation);
            }
        
    }
}
