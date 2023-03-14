using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControls : MonoBehaviour
{
    private Light TheLights;



    // Start is called before the first frame update
    void Start()
    {
        TheLights = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.F))
        {
            TheLights.enabled = !TheLights.enabled;
        }
    }
}
