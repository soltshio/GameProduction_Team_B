using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�쐬��:���R
//�Q�[���V�[���ł̎c�莞�ԃX�R�A�̌v���E����
public class ScoreGameScene_TimeLimit : MonoBehaviour
{
    [Header("�c�莞��(1�b)���Ƃ̃X�R�A��")]
    [SerializeField] float m_scorePerSecond;//�c�莞��(1�b)���Ƃ̃X�R�A��
    [Header("�X�R�A���f�Ɏg���R���|�[�l���g")]
    [SerializeField] Score_TimeLimit_ score_TimeLimit;//�X�R�A���f
    const float remainingTime_GameOver = 0;//�Q�[���I�[�o�[�������I�Ɏc�莞�Ԃ�0�Ƃ���

    public void Reflect(bool gameClear)//�X�R�A���f
    {
        float score = (gameClear ? TimeLimit.RemainingTime : remainingTime_GameOver) * m_scorePerSecond;

        score_TimeLimit.Rewrite(score, TimeLimit.RemainingTime, m_scorePerSecond);
    }
}