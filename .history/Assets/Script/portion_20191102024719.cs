using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portion : MonoBehaviour
{
    public Text RecoveryText;
    private int recovery;
    void Start()
    {
      Initialize ();
    }

    // Update is called once per frame
    void Update()
    {
      RecoveryText.text = recovery.ToString ();
    }
    private void Initialize ()
    {
      recovery = 2;
    }
    public void use ()
    {
        recovery = recovery - 1;

        if(recovery <= 0){
          recovery = 0;
        }
    }
}
