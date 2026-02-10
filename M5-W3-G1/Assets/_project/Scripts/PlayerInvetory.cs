using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvetory : MonoBehaviour
{
    public List<ItemSO> invetory;
    [SerializeField] GameObject me;

    private void Update()
    {
        if(invetory != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && invetory[0]!=null)
            {
                Debug.Log("sto premendo 1");
                invetory[0].UseItem(me);
                invetory[0].DescriptionItem();
                invetory.Remove(invetory[0]);
    
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) && invetory[1] != null)
            {
                Debug.Log("sto premendo 2");
                invetory[1].UseItem(me);
                invetory[0].DescriptionItem();
                invetory.Remove(invetory[1]);


            }


        }
    }
}
