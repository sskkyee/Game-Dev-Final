using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwitchTrigger"))
        {
            SceneManager.LoadScene("Red");
        }
        else if (other.CompareTag("SwitchTrigger2"))
        {
            SceneManager.LoadScene("Blue");
        }
    }
}
