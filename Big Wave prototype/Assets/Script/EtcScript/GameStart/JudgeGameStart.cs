using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//作成者:杉山
//ゲームスタート時のカウントダウン
public class JudgeGameStart : MonoBehaviour
{
    [Header("画面遷移してから何秒でゲームを開始するか")]
    [SerializeField] float gameStartTime;//画面遷移してから何秒でゲームを開始するか
    [Header("ゲーム開始瞬間の処理")]
    [SerializeField] MomentEvent startGameEvents;//ゲーム開始瞬間の処理(メソッド)
    private float remainingGameStartTime;//現在のゲーム開始までの残り時間
    private bool isStarted = false;//ゲームが開始されたか(カウントダウンは終わったか)
    private bool isStartedBeforeFrame=false;//前のフレームのisStarted

    public float RemainingGameStartTime { get { return remainingGameStartTime; } }

    public bool IsStarted { get { return isStarted; } }

    void Start()
    {
        remainingGameStartTime = gameStartTime;//現在のゲーム開始までの残り時間を設定
    }

    void Update()
    {
        UpdateGameStart();

        startGameEvents.ActivateMomentEvent(isStarted,isStartedBeforeFrame,true);//前のフレームでまだゲーム開始されてないかつ現在のフレームで開始されていたらゲーム開始瞬間の処理を行う

        isStartedBeforeFrame = isStarted;//前のフレームのゲーム開始状況を記録
    }

    //ゲーム開始状況の更新
    //残り0秒になったらゲーム開始する
    void UpdateGameStart()
    {
        if (isStarted) return;//ゲームが開始されたら残り時間の更新をしない
        //ゲームが開始されていない間、残り時間を更新
       
        remainingGameStartTime -= Time.deltaTime;

        if(remainingGameStartTime<=0) isStarted = true;//残り時間が0以下になったらゲーム開始
    }
}
