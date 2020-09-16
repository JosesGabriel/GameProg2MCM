using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {

            //Player player = other.GetComponent<Player>();
            //if (player != null) player.Die();
            SceneManager.LoadScene("Main");

            Debug.Log("test :>");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
