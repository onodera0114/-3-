using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portion : MonoBehaviour
{
    public Text RecoveryText;
    private int recovery;
    GameObject hero;
    Hero script;
    void Start()
    {
      script = hero.GetComponent<Hero>();
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
        if(recovery <= 0){
          recovery = 0;
        }
        else{
          recovery = recovery - 1;
        }
        script.use = true;

    }
}
