using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flikering : MonoBehaviour
{
    Light Testlight;
    public float MinWaitTime;
    public float MaxWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        Testlight = GetComponent<Light>();
        StartCoroutine(Flashing());

    }
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(MinWaitTime, MaxWaitTime));
            Testlight.enabled = !Testlight.enabled;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
