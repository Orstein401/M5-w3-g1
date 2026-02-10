using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PLayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] public int life;
    float h;
    float v;

    Rigidbody rb;

    [SerializeField] private UnityEvent<int> eventsUi;
    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir= new Vector3(h,0,v);
        dir.Normalize();

        rb.velocity = dir*speed;

    }

    public void CAmbiaVIta(int newLife)
    {
        eventsUi.Invoke(newLife);
    }
}
