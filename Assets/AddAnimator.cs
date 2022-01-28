using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAnimator : MonoBehaviour
{

    [SerializeField] xsens.XsStreamReader actor;
    // Start is called before the first frame update
    void Awake()
    {
        xsens.XsLiveAnimator sc = this.gameObject.AddComponent<xsens.XsLiveAnimator>();

        
        StartCoroutine(AddOtherScriptAfterAWhile());
    }

    IEnumerator AddOtherScriptAfterAWhile()
    {
        yield return new WaitForSeconds(1);

        xsens.XsLiveAnimator ani = GetComponent<xsens.XsLiveAnimator>();
        ani.Setup(actor, this.transform);
    }
}
