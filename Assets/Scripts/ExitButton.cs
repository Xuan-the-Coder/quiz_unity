using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitApp()
    {
        Debug.Log("Exiting app");
        Application.Quit(0);
    }
}
