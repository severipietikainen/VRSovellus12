using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetHit : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter (Collider other)
    {
    Debug.Log(other.gameObject);
        if (other.gameObject.tag == "Bullet")
        {
            score =+ 1;
            Destroy(gameObject);
            
        }
          if (score == 5)
        {
         SceneManager.LoadScene("Win");
        }
    }
}
