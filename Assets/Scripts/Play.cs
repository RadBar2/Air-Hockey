using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    void Update()
    {
        SceneManager.LoadScene("Sample Scene");
    }
}
