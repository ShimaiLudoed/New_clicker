using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorCon : MonoBehaviour
{
    public bool InfoPan1=true;
    public bool InfoPan2 = true;
    public bool InfoPan3 = true;
    public bool InfoPan4 = true;
    public bool InfoPan5 = true;
    public static TutorCon Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(target:this);
    }
}
