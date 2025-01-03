using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成者：桑原

[System.Serializable]
public class InertialRotateParameter : MonoBehaviour
{
    [Header("▼回転に関する設定")]
    [Header("回転の強さ")]
    [SerializeField] float rotationStrength = 10f;
    [Header("最大回転角度")]
    [SerializeField] float maxRotationAngle = 45f;
    [Header("回転をもとに戻す速さ")]
    [SerializeField] float rotationReturnSpeed = 10f;

    public float RotationStrength { get { return rotationStrength; } }
    public float MaxRotationAngle { get { return maxRotationAngle; } }
    public float RotationReturnSpeed { get {  return rotationReturnSpeed; } }
}