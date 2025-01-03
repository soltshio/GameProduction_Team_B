using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

//作成者:杉山
//ゲーム中にスコア(トリックコンボとチャージ時間)を表示させる
public class TrickComboScoreDisplay : MonoBehaviour
{
    [Header("スコア表示する文字")]
    [SerializeField] TMP_Text m_scoreText;
    [Header("トリックコンボのスコアを計測するコンポーネント")]
    [SerializeField] ScoreGameScene_TrickCombo score_TrickCombo;
    [Header("チャージ時間のスコアを計測するコンポーネント")]
    [SerializeField] ScoreGameScene_ChargeTime score_ChargeTime;
    [Header("表示する文字の増えるスピード")]
    [SerializeField] float m_riseSpeed;
    private float displayScore=0;//表示用のスコア(増える際、瞬間的に数字を切り替えるのではなくナンバーカウンターのように増やす演出実装のため)
    const float defaultScore=0;//スコア初期値

    void Update()
    {
        Display();
    }

    void Display()//表示する
    {
        //現在のスコア
        float score = score_TrickCombo.Score+score_ChargeTime.Score;

        //現在のスコアになるまで増え続ける
        displayScore += Time.deltaTime*m_riseSpeed;
        displayScore = Mathf.Clamp(displayScore, defaultScore, score);

        m_scoreText.text = displayScore.ToString("0");
    }
}
