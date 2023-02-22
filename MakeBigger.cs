using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBigger : MonoBehaviour
{
    Coroutine _myTimer;
    private bool _isFinshedCounting;


    // Start is called before the first frame update
    void Start()
    {
        _myTimer = StartCoroutine(GetBiggerOverTime(2));
    }

    // Update is called once per frame
    void Update()
    {
      if(_isFinshedCounting == false)
        {
            MakeItBigger();
        }
    }
    IEnumerator GetBiggerOverTime(int _timer)
    {
        _isFinshedCounting = false;
        int i = 0;
        while(i < _timer)
        {
            i++;
            Debug.Log(i);
            yield return new WaitForSeconds(1);
        }
        _isFinshedCounting = true;
        Debug.Log("Finished");
    }
    void MakeItBigger()
    {
        transform.localScale += new Vector3(.01f, .01f, 0);
    }
}
