using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�쐬��:���R
//�W�����v���x�ō��_�ɓ��B��������Ԃ�
public class JudgeOnceReachedHighestPoint_Jumping : MonoBehaviour
{
    bool reached=false;//�W�����v��1��͍ō��_�ɓ��B������
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        JudgeFirstReachHighestPoint();
    }

    void JudgeFirstReachHighestPoint()
    {
        bool fallNow = (rb.velocity.y < 0);//�����Ă��邩

        if(fallNow)//�܂��ō��_�ɓ��B���ĂȂ��������Ă��鎞��
        {
            reached = true;//�W�����v��1��͍ō��_�ɓ��B�����Ƃ������Ƃɂ���
        }
    }

    public void StartJump()//�W�����v���n�߂ɌĂяo��
    {
        reached=false;//�W�����v��1����ō��_�ɓ��B���ĂȂ��Ƃ������Ƃɂ���
    }

    public bool Reached
    {
        get { return reached; }
    }

    
}