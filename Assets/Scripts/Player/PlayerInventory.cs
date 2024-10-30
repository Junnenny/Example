using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount = 0;
    public TMP_Text keyCountText;

    private void Start()
    {
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Ключи: " + keyCount;
    }

    public int GetKeyCount()
    {
        return keyCount;
    }
}

