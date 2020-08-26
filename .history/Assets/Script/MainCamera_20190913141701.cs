using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        obj = GameObject.Find("hero");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, -10);
    }
}
