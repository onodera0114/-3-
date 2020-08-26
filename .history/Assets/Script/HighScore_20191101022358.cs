using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    private int HS;

    void Start()
    {
      HS =
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text =HS.ToString ();
    }
}
