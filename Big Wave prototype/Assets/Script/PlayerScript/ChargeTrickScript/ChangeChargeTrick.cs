using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChargeTrick : MonoBehaviour
{
    [Header("最大までたまりやすくなった時の倍率(最大倍率)")]
    [SerializeField] float chargeRateMax=1;//最大倍率
    [Header("最大倍率になるまでにかかる時間")]
    [SerializeField] float byRateMaxTime=10;//最大倍率になるまでにかかる時間
    private float currentChargeRate=1f;//現在の倍率
    private float curremtChangeChargeRateTime=0;//倍率が変化している時間

    JumpControl jumpControl;
    JudgeTouchWave judgeTouchWave;
    ChangeChargeTrickEffect changeChargeTrickEffect;

    public float CurrentChargeRate
    {
        get { return currentChargeRate; }
    }

    public float ChargeRateMax
    {
        get { return chargeRateMax; }
    }

    // Start is called before the first frame update
    void Start()
    {
        jumpControl = GetComponent<JumpControl>();
        judgeTouchWave = GetComponent<JudgeTouchWave>();
        changeChargeTrickEffect = GetComponent<ChangeChargeTrickEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeChargeRate();
    }

    bool ChangeChargeRateNow()//波に触れているかジャンプしている時に倍率が変化するようにする
    {
        if(jumpControl.JumpNow||judgeTouchWave.TouchWaveNow)
        {
            return true; 
        }
       
        return false;
    }

    void ChangeChargeRate()
    {
        //波に触れているかジャンプしている時、byRateMaxTimeかけて倍率が1倍からchargeRateMax倍まで変化する
        if (ChangeChargeRateNow())
        {
            curremtChangeChargeRateTime += Time.deltaTime;
            curremtChangeChargeRateTime = Mathf.Clamp(curremtChangeChargeRateTime, 0, byRateMaxTime);

            currentChargeRate = 1 + (chargeRateMax - 1) *RatioOfChargeRate();
            currentChargeRate = Mathf.Clamp(currentChargeRate,1,chargeRateMax);

            changeChargeTrickEffect.ChangeEffectScale();
        }
        //そうでない時、倍率が等倍に戻る
        else
        {
            curremtChangeChargeRateTime = 0;
            currentChargeRate = 1f;
            changeChargeTrickEffect.ResetEffectScale();
        }
    }

    public float RatioOfChargeRate()
    {
        return curremtChangeChargeRateTime / byRateMaxTime;
    }
}
