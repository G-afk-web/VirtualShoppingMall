using UnityEngine;

public class ObjectOnCanvas : MonoBehaviour
{
    public Canvas canvas;
    
    void Start()
    {
        // Canvasの子オブジェクトになるようにする
        transform.SetParent(canvas.transform, false);
    }
}