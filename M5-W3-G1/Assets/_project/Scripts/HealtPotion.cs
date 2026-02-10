using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemGame/potion/HealthPotion")]
public class HealtPotion : ItemSO
{
    [SerializeField] int cure;
    public override void UseItem(GameObject person)
    {
        if (person.TryGetComponent<PLayerController>(out var playerLife))
        {
            playerLife.life += cure;
            playerLife.CAmbiaVIta(playerLife.life);
        }
    }
}
