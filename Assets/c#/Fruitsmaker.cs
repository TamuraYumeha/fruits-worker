using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitsmaker : MonoBehaviour
{
    public GameObject[] Train;
    public float makeTime;
    private float waitTime;
    private int num;
    public int perMax;
    public int per1;
    public int per2;
    public int per3;
    public int per4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }

        else
        {
            num = Random.Range(1, perMax);

            if (1 <= num && num < per1)
                Instantiate(Train[0], transform.position, transform.rotation);

            if (per1 <= num && num < per2)
                Instantiate(Train[1], transform.position, transform.rotation);

            if (per2 <= num && num < per3)
                Instantiate(Train[2], transform.position, transform.rotation);

            if (per3 <= num && num < per4)
                Instantiate(Train[3], transform.position, transform.rotation);

            if (per4 <= num && num <= perMax)
                Instantiate(Train[4], transform.position, transform.rotation);

            waitTime = 0;
        }
    }
}
