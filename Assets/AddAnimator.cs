using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAnimator : MonoBehaviour
{

    [SerializeField] xsens.XsStreamReader actor;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddOtherScriptAfterAWhile());
    }

    IEnumerator AddOtherScriptAfterAWhile()
    {
        yield return new WaitForSeconds(5);
        xsens.XsLiveAnimator sc = gameObject.AddComponent(typeof(xsens.XsLiveAnimator)) as xsens.XsLiveAnimator;
        sc.Setup(actor);
        
    }
}
