using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManeger : MonoBehaviour
{
  public GameObject gameoverObj;
  public GameObject hero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart(){
      gameoverObj.SetActive(false);
      SceneManager.LoadScene("title");
    }

    public void GameOver(){
      gameoverObj.SetActive(true);
      hero.SetActive(false);
      FindObjectOfType<Score>().Save();
      Invoke("GameStart", 5f);
    }
}
