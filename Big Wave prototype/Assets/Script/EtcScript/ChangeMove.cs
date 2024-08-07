using UnityEngine;

public class ChangeMove : MonoBehaviour
{
    // 往復する長さ
    [SerializeField] private float _length = 50;
    public float speed = 10;
    private void Update()
    {
        // 往復した値を時間から計算
        var value = Mathf.PingPong(Time.time*speed, _length) - _length / 2; ;

        // y座標を往復させて上下運動させる
        transform.Translate(Vector3.right * value * Time.deltaTime);
    }
}