using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WallGenerationParameters
{
    [Header("生成する壁の横の分割数")]
    [SerializeField] int width = 3;
    [Header("生成する壁の縦の分割数")]
    [SerializeField] int height = 3;
    [Header("壁の最大生成枚数")]
    [SerializeField] int generateWallsNum = 6;
    [Header("それぞれの壁が生成される確率")]
    [SerializeField] float generationProbability = 1f;
    [Header("壁一枚ごとの出現間隔")]
    [SerializeField] float intervalActiveTime = 0.2f;
    [Header("生成範囲をゲーム画面に合わせるかどうか")]
    [SerializeField] bool matchCameraSize = true;

    public int Width { get { return width; } }
    public int Height { get { return height; } }
    public int GenerateWallsNum { get { return generateWallsNum; } }
    public float GenerationProbability { get { return generationProbability; } }
    public float IntervalActiveTime { get { return intervalActiveTime; } }
    public bool MatchCameraSize { get { return matchCameraSize; } }
}