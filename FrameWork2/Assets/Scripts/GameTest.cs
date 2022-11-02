using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class GameTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameEntry.Shutdown(ShutdownType.None);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameEntry.Shutdown(ShutdownType.Restart);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameEntry.Shutdown(ShutdownType.Quit);
        }
    }
}
