using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltolevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "level exit")
        {
            SceneManager.LoadScene("Level 2");
        }

        void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
