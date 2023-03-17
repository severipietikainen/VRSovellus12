using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;
  
  

    
    public GameObject target;

    void Start()
    {

      isPressed = false;  

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void Spawtarget1()
    {
        GameObject spawnedtarget = Instantiate(target);
        spawnedtarget.transform.position = spawnPoint1.position;
       
         
    }
      public void Spawtarget2()
    {
        GameObject spawnedtarget = Instantiate(target);
        spawnedtarget.transform.position = spawnPoint2.position;
       
         
    }
      public void Spawtarget3()
    {
        GameObject spawnedtarget = Instantiate(target);
        spawnedtarget.transform.position = spawnPoint3.position;
       
         
    }
      public void Spawtarget4()
    {
        GameObject spawnedtarget = Instantiate(target);
        spawnedtarget.transform.position = spawnPoint4.position;
       
         
    }
      public void Spawtarget5()
    {
        GameObject spawnedtarget = Instantiate(target);
        spawnedtarget.transform.position = spawnPoint5.position;
       
         
    }

  

   
}
