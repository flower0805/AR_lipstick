using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class open_gift : MonoBehaviour
{

    public GameObject cube;
    public GameObject fbx;
    public GameObject leftcard;
    public GameObject rightcard;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhoSelect()
    {
        if(cube.active == false && count == 0 && fbx.active == false)
        {
            cube.SetActive(true);
            count = 1;
        }else if (fbx.active == true && count == 1)
        {
            fbx.SetActive(false);
            leftcard.SetActive(true);
            rightcard.SetActive(true);
            count = 0;
        }
    }


}
