using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.RotateAround(new Vector3 (1, 0, 1), transform.up, 45*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
