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
                    case SlotBoxData.BuildType.枪械流:
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
    /// 枪械流
    /// </summary>
    void gunBuild()
    {

    }


    /// <summary>
    /// 检测box周围8个box的属性
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
