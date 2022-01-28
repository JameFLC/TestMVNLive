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
            float Xoffset = 0.5f;
            bosses[i].transform.Translate(new Vector3( i* Xoffset - maxBosses/2.0f * Xoffset, 0, -i*0.1f));

            animators[i] = Instantiate(animationController, transform);
            animators[i].GetComponent<xsens.XsLiveAnimator>().Setup(actor, bosses[i].transform);
        }




        

        
    }
}
