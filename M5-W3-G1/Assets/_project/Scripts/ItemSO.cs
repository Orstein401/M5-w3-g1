using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class ItemSO : ScriptableObject
{
    [SerializeField] public string nameItem;
    [SerializeField] public string description;
    [SerializeField] public float price;

    public abstract void UseItem(GameObject player);
}
