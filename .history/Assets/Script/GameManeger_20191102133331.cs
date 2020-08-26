using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManeger : MonoBehaviour
{
  public GameObject gameoverObj;
  public GameObject hero;
  Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.Escape)){
        Quit();
      }

      if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.T)){
        SceneManager.LoadScene("title");
      }
    }
    void Quit() {
  #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
  #elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
  #endif
}

    public void GameStart(){
      gameoverObj.SetActive(false);
      SceneManager.LoadScene("title");
    }

    public void GameOver(){
      gameoverObj.SetActive(true);
      hero.rigidbody = GetComponent<Rigidbody2D>();
      Renderer renderComponent = hero.GetComponent<Renderer>();

      rigidbody.velocity = new Vector2(0, 0);
      renderComponent.enabled = false;
      hero.GetComponent<BoxCollider2D>().enabled = false;
      hero.GetComponent<Hero>().enabled = false;
      hero.GetComponent<Hero_anime>().enabled = false;

      FindObjectOfType<Score>().Save();
      Invoke("GameStart", 5f);
    }
}
