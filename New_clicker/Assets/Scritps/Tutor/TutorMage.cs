using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorMage : MonoBehaviour
{
    public GameObject Infopan1;
    public GameObject Infopan2;
    public GameObject Infopan3;
    public GameObject Infopan4;
    public GameObject Infopan5;
    void Start()
    {
        if (TutorCon.Instance.InfoPan1 == false)
        {
            Infopan1.SetActive(false);
        }
        if (TutorCon.Instance.InfoPan2 == false)
        {
            Infopan2.SetActive(false);
        }
        if (TutorCon.Instance.InfoPan3 == false)
        {
            Infopan3.SetActive(false);
        }
        if (TutorCon.Instance.InfoPan4 == false)
        {
            Infopan4.SetActive(false);
        }
        if (TutorCon.Instance.InfoPan5 == false)
        {
            Infopan5.SetActive(false);
        }
        
    }

    public void Close1()
    {
        TutorCon.Instance.InfoPan1 = false;
    }

    public void Close2()
    {
        TutorCon.Instance.InfoPan2 = false;
    }

    public void close3()
    {
        TutorCon.Instance.InfoPan3 = false;
    }
    public void close4()
    {
        TutorCon.Instance.InfoPan4 = false;
    }

   
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
