using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Удалить : MonoBehaviour
{
    [SerializeField] private GameObject massegeBox;
    [SerializeField] private UnityEvent enter;
    [SerializeField] private UnityEvent exit;

    protected void OnTriggerEnter(Collider other)
    {
        enter.Invoke();
        massegeBox.SetActive(true);
        
    }

    private void OnTriggerExit(Collider other)
    {
        exit.Invoke();
        massegeBox.SetActive(false);
    }
}
