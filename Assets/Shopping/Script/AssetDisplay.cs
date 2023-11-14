using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetDisplay : MonoBehaviour {
    // オブジェクトをクリックしたらパネルが表示されオブジェクト詳細が閲覧できる
    public GameObject panel; // パネルの参照
    public GameObject objectPrefab; // 3Dオブジェクトのプレハブ

    private void OnMouseDown() {
        // パネルの表示
        panel.SetActive(true);

        // オブジェクトを複製
        GameObject newObject = Instantiate(objectPrefab, panel.transform);

        // サイズやポジション設定
        newObject.transform.localPosition = Vector3.zero;
        newObject.transform.localRotation = Quaternion.identity;
        // Vector3 originalScale = objectPrefab.transform.localScale; // 元のオブジェクトのスケールを取得
        // newObject.transform.localScale = originalScale; // 複製されたオブジェクトに同じスケールを設定

        // オブジェクトの元のマテリアルをコピー
        Renderer originalRenderer = objectPrefab.GetComponent<Renderer>();
        if (originalRenderer != null) {
            Material originalMaterial = originalRenderer.material;
            Material copiedMaterial = new Material(originalMaterial);
            Renderer newObjectRenderer = newObject.GetComponent<Renderer>();
            newObjectRenderer.material = copiedMaterial;
        }

        // 表示
        newObject.SetActive(true);
    }
}

