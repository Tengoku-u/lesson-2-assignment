using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float keyLaunchInterval = 1.5f; //time interval between spacebar key press
    private float nextKeyLaunch = 0; // next keylaunch time 


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has passed, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextKeyLaunch)
        {
            nextKeyLaunch = Time.time + keyLaunchInterval;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
