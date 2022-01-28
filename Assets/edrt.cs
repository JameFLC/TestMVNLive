using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edrt : MonoBehaviour
{
    [SerializeField] GameObject bossPrefab;
    [SerializeField] GameObject animationController;
    [SerializeField] Transform variantSpawn;
    [SerializeField] xsens.XsStreamReader actor;

    [SerializeField] int maxBosses = 5;
    private GameObject[] bosses;
    private GameObject[] animators;
    // Start is called before the first frame update
    void Start()
    {
        bosses = new GameObject[256];
        animators = new GameObject[256];
        StartCoroutine(AddOtherScriptAfterAWhile());
    }

    IEnumerator AddOtherScriptAfterAWhile()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < maxBosses; i++)
        {
            Debug.Log(bosses);
            bosses[i] = Instantiate(bossPrefab, transform);
            Debug.Log(bosses);
            bosses[i].transform.Translate(new Vector3( i - maxBosses/2.0f, 0, 0));

            animators[i] = Instantiate(animationController, transform);
            animators[i].GetComponent<xsens.XsLiveAnimator>().Setup(actor, bosses[i].transform);
        }




        

        
    }
}
