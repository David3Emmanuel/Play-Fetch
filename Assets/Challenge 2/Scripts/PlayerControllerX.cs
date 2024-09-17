using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float waitPeriod = 1.0f;
    private float currentWaitTime = 0;

    // Update is called once per frame
    void Update()
    {
        currentWaitTime -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && currentWaitTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            currentWaitTime = waitPeriod;
        }
    }
}
