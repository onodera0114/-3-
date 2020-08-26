using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public Text HPText;
    private int HP;
    void Start()
    {
      Initialize ();
    }

    // Update is called once per frame
    void Update()
    {
      HPText.text = HP.ToString ();
    }
    private void Initialize ()
    {
      HP = 100;
    }
    public void Damage (int damage)
    {
        HP = HP - damege;
    }
}
