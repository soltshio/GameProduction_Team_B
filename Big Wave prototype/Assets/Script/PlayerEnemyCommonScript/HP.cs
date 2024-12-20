using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

//作成者:杉山
//HP
public class HP : MonoBehaviour
{
    [Header("最大体力")]
    [SerializeField] float hpMax = 500;//最大体力
    private float hp = 500;//現在の体力
    bool _dead=false;//死亡判定
    bool _fix=false;//体力が増減しないよう固定
    const float _deadHp = 0;//死亡条件残り体力
    
    public bool Fix
    {
        get { return _fix; }
        set { _fix = value; }
    }

    public float Hp
    {
        get { return hp; }
        set 
        {
            if (_fix||_dead) return;//固定時または死亡時は体力を変動させない

            hp = value;
           
            if (hp <= _deadHp && !_dead)//死亡時
            {
                _dead = true;
            }

            hp = Mathf.Clamp(hp, _deadHp, hpMax);//体力が限界突破しないように
        }
    }

    public float HpMax
    {
        get { return hpMax; }
        set { hpMax = value; }
    }

    void Start()
    {
        //Hpの初期化
        hp = hpMax;   
    }
}
