using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPlatform : MonoBehaviour
{
        [SerializeField] private GameObject _popup;
        
        private void OnCollisionEnter(Collision collision)
        {
                if (collision.gameObject.tag == "Player")
                {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                        if (SceneManager.GetActiveScene().buildIndex == 4)
                        {
                                Instantiate(_popup);

                                Time.timeScale = 0;
                        }
                }
        }
}
