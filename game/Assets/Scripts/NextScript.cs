using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScript : MonoBehaviour
{
    public void NextButton(int i)
    {
        SceneManager.LoadScene(i);
    }
}
