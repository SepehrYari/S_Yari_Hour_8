using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public GameObject GameObject;
    private Renderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Renderer.enabled = !Renderer.enabled;
        }
    }
}
