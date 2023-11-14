using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemDatabase : ScriptableObject {
    // AssetItemのリスト
    public List<AssetItem> itemList = new List<AssetItem>();
}
