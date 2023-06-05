using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionButtonClick : MonoBehaviour
{

    public void TrueButton()
    {
         new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }

    public void WrongButton()
    {
        SceneManager.LoadScene(0);
    }
}
