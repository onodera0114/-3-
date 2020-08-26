using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
  int i = 0;
  int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine("wait");
            while(true){
        transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1f), 5);
        i++;
        if(i >= 18){
          break;
        }
      }
    }

    // Update is called once per frame
    void Update()
    {

      //if(i < 19){
      //  transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1f), 5);
      //  i++;
    }

    IEnumerator wait(){
      yield return new WaitForSeconds(1);
    }
}
