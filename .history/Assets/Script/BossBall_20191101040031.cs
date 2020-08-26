using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
 // 移動スピード
  public float speed = 10f;

  // 弾を撃つ間隔
  public float shotDelay = 10f;

  // 弾のPrefab
  public GameObject bossball;

  // 弾の作成
  public void Shot (Transform origin)
  {
    Instantiate (bossball, origin.position, origin.rotation);
  }

}
