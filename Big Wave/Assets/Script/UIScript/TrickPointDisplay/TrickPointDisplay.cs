using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//作成者:杉山
public class TrickPointDisplay : MonoBehaviour
{
    [Header("プレイヤーのトリックゲージ")]
    [Header("注意点:トリックゲージの本数分入れてください")]
    [SerializeField] Image[] trickGauges;
    [Header("▼通常状態のトリックゲージの色")]
    [SerializeField] Color trickGaugeNormalColor;//通常状態のトリックゲージの色
    [Header("▼満タン状態のトリックゲージの色")]
    [SerializeField] Color trickGaugeMaxColor;//満タン状態のトリックゲージの色
    [Header("プレイヤーのトリックポイント")]
    [SerializeField] TrickPoint player_TrickPoint;
    const float maxRatio = 1;//トリックゲージ満タン時の割合

    // Start is called before the first frame update
    void Start()
    {
        //エラーコード
        if (player_TrickPoint.TrickGaugeNum != trickGauges.Length) Debug.Log("トリックゲージの本数分登録してください");
    }

    void Update()
    {
        TRICKGaugeOfPlayer();//プレイヤーのトリックゲージの処理
    }

    void TRICKGaugeOfPlayer()//プレイヤーのトリックゲージの処理
    {
        for (int i = 0; i < trickGauges.Length; i++)
        {
            float trickRatio = player_TrickPoint[i] / player_TrickPoint.TrickPointMax;
            trickGauges[i].fillAmount = trickRatio;


            //ゲージの色の変更(ゲージ1個ごとに満タン時とそれ以外の時でゲージの色を切り替える)
            trickGauges[i].color = trickRatio == maxRatio ? trickGaugeMaxColor : trickGaugeNormalColor;
        }
    }
}
