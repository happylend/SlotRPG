using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildController : MonoBehaviour
{
    private RandomAssets randomassetsScript;

    // Start is called before the first frame update
    void Start()
    {
        if (randomassetsScript == null) { randomassetsScript = Object.FindObjectOfType<RandomAssets>(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkBuild()
    {
        for (int i = 0; i < randomassetsScript.currentBox.GetLength(0); i++)
        {
            for (int j = 0; j < randomassetsScript.currentBox.GetLength(1); j++)
            {
                switch(randomassetsScript.currentBox[i,j].buildtype)
                {
                    case SlotBoxData.BuildType.ǹе��:
                        {
                            gunBuild();
                            break;
                        }
                        


                    default:
                        {

                            break;
                        }

                }



            }
        }
    }

    /// <summary>
    /// ǹе��
    /// </summary>
    void gunBuild()
    {

    }


    /// <summary>
    /// ���box��Χ8��box������
    /// </summary>
    void getAroundBox(int boxI, int boxJ)
    {
        if (boxI == 0)
        {
            if (boxJ == 0)
            {

            }
        }

    }
}
