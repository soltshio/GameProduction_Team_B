using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成者:杉山
//波に触っているか判断
public class JudgeTouchWave : MonoBehaviour
{
    [SerializeField] OnTriggerActionEvent onTriggerActionEvent;
    [SerializeField] float touchBorderTime = 0.1f;//触った・触ってないの境界の時間
    private bool touchWaveNow=false;//今波に触っているか
    private float sinceLastTouchWaveTime = 0.1f;//最後に波に触ってからの時間
   
    public bool TouchWaveNow
    {
        get { return touchWaveNow; }
    }

    // Start is called before the first frame update
    void Start()
    {
        onTriggerActionEvent.EnterAction += TouchWave;
        sinceLastTouchWaveTime = touchBorderTime;
    }

    // Update is called once per frame
    void Update()
    {
        JudgeTouchWaveNow();//波に触れているか判定
    }

    public void TouchWave(Collider c)
    {
        if (c.gameObject.CompareTag("InsideWave") || c.gameObject.CompareTag("OutsideWave"))
        {
            sinceLastTouchWaveTime = 0f;//最後に波に触ってからの時間を更新
        }
    }

    void JudgeTouchWaveNow()//波に触れているか判定
    {
        sinceLastTouchWaveTime += Time.deltaTime;

        if (sinceLastTouchWaveTime < touchBorderTime)//最後に触ってからtouchBorderTime秒未満しか経っていなければ今波に触れている判定
        {
            touchWaveNow = true;
        }
        else
        {
            touchWaveNow = false;
        }
    }
}
