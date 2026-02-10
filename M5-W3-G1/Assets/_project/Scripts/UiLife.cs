using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiLife : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void ChangeLife(int life)
    {
        text.SetText($"{life}/100");
    }
}
