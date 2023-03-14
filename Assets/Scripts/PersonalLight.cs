using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalLight : MonoBehaviour
{
    private Light TheLights;



    // Start is called before the first frame update
    void Start()
    {
        TheLights = GetComponent<Light>();
        TheLights.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.L))
        {
            TheLights.enabled = !TheLights.enabled;
        }
    }
}
