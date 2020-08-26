using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Text HPText;
    private int hp;
    void Start()
    {
      Initialize ();
    }

    // Update is called once per frame
    void Update()
    {
      HPText.text = hp.ToString ();
    }
    public void Initialize ()
    {
      hp = 150;
    }
    public void Damage (int damage)
    {
        hp = hp - damage;

        if(hp <= 0){
          FindObjectOfType<GameManeger>().GameOver();
        }
    }
}
