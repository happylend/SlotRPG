using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttribute : MonoBehaviour
{
    private CubeManager cubemanagerScript;

    public cubeAttribute boxAttribute;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SpriteRenderer>().sprite = boxAttribute.image;
    }
}
