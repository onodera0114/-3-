using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
 // 移動スピード
  public float speed;

  // 弾を撃つ間隔
  public float shotDelay;

  // 弾のPrefab
  public GameObject BossBall;

  // 弾の作成
  public void Shot (Transform origin)
  {
    Instantiate (BossBall, origin.position, origin.rotation);
  }

}
