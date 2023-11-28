using UnityEngine;

public class LookAwayFromTarget : MonoBehaviour
{
    public Transform target; // 対象のTransformを指定

    void Update()
    {
        if (target != null)
        {
            // 対象の方向を取得
            Vector3 lookDirection = target.position - transform.position;

            // 反対方向を向くように回転
            transform.rotation = Quaternion.LookRotation(-lookDirection);

            // もしY軸の回転を無効にする場合は、以下のコメントアウトを解除
            // transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
        // 対象がnullの場合は何もしない
    }
}
