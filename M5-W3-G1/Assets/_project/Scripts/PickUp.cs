using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private ItemSO item;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerInvetory>(out var player))
        {
            player.invetory.Add(item);
            Destroy(gameObject);
        }
    }
}
