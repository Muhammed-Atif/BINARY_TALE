using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LevelTransitionScript
{
    public class LevelTransition : MonoBehaviour
    {
        public GameObject panel;
        private void OnTriggerEnter2D(Collider2D collision)
        {


            if (collision != null)
            {
                if (collision.tag.Equals("Player"))
                {
                    panel.SetActive(true);
                }
            }
        }

        private IEnumerator LoadDelay()
        {
            yield return new WaitForSeconds(2f);
            TransitionNextLevel();
        }

        private void TransitionNextLevel()
        {

        }
    }
}
