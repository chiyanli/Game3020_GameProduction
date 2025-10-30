using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class SaveData
{
    public Vector3 playerPosition;
    public string mapBoundry; //The boundry name forthe map
    public List<InventorySaveData> inventorySaveData;
    public List<InventorySaveData> hotbarSaveData;
}
