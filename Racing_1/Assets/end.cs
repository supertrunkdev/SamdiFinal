using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RGSK
{
    public class end : MonoBehaviour
    {
        [SerializeField] private int ��ǥ������ = 3;
        private int count;

        [SerializeField] private GameObject _ui;


        private void Start()
        {
            _ui.gameObject.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("end"))
            {
                count += 1;

                if (count == ��ǥ������)
                {
                    _ui.gameObject.SetActive(true);

                    StartCoroutine(EndWaiter());
                }
            }
        }

        IEnumerator EndWaiter()
        {
            yield return new WaitForSeconds(2);

            SceneManager.LoadScene("DemoHub");
        }
    }
}
