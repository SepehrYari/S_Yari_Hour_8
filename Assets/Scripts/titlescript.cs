using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlescript : MonoBehaviour
{
    public GameObject GameObject;
    private Renderer Renderer;
    private SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gameObject.GetComponent<Renderer>().enabled = false;

        }
    }
}
