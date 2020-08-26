using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
  public int i = 0;;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      while(true){
        transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1f), 45);
        i++;
        if(i == 2){
          break;
        }

        Destroy(this.gameObject);
      }
    }
}
