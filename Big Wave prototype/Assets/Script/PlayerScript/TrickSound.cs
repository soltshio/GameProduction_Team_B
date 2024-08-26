using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�g���b�N���ɉ����ꂽ�{�^���ɑΉ��������݂̃g���b�N�p�^�[���̌��ʉ����擾���Č��ʉ����Đ�����
public class TrickSound : MonoBehaviour
{
    PushedButton_CurrentTrickPattern pushedButton_TrickPattern;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        pushedButton_TrickPattern=GetComponent<PushedButton_CurrentTrickPattern>();
        audioSource=GetComponent<AudioSource>();
    }

    public void SoundEffect()//�g���b�N�̌��ʉ��̍Đ�
    {
        AudioClip soundEffect = pushedButton_TrickPattern.SoundEffect;//�����ꂽ�{�^���ɑΉ��������݂̃g���b�N�p�^�[��������ʉ����擾
        audioSource.PlayOneShot(soundEffect);//���ʉ����Đ�
    }
}