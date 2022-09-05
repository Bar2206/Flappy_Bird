using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class LeaderBoard : ScriptableObject
{
    
    public int [] array = new int[5];
    public void addScore (int score)
    {
        for (int i = 0; i < 5; i++)
        {
            if(score>array[i])
            {
                for(int j=i; j<4; j++)
                {
                    if(array[j + 1]==0)
                    {
                        array[j + 1] = array[j];
                        break;
                    }
                    else 
                    {
                        array[j + 1] = array[j];
                    }


                }
                array[i] = score;
                break;
            }
        }
    }

}
