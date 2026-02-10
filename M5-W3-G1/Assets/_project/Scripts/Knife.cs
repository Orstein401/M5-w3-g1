using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemGame/Weapon/Knife")]

public class Knife : ItemSO
{
    [SerializeField] int damage;
    public override void UseItem(GameObject person)
    {
        if (person.TryGetComponent<PLayerController>(out var playerLife))
        {
            playerLife.life -= damage;
            playerLife.CAmbiaVIta(playerLife.life);
        }
    }

}
