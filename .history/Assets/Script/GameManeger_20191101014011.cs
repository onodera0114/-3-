﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
  public GameObject gameoverObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart(){

    }

    public void GameOver(){
      gameoverObj.SetActive(true);
      FindObjectOfType<Score>().Save();
    }
}
