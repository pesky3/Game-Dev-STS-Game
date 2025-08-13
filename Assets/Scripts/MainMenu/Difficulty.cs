using UnityEngine;

public class Difficulty : MonoBehaviour
{
    private static DifficultyEnum difficultySetting = DifficultyEnum.Normal;
    //initially made  public static float enemyHealthMultiplier;     public static float enemyHealthMultiplier; variables but decided to turn them into methods
    // something ive learnt through coding this project is that you can actually put methods in method parameters so long as the return type matches the method's data type, allowing for this implementation of difficulty scaling;


    public static DifficultyEnum DifficultySetting
    {
        get { return difficultySetting;  }
        set { difficultySetting = value;  }
    }


    public enum DifficultyEnum
    {
        Normal, Hard
    }

    public static (float healthMultiplier, float strengthMultiplier) EnemyDifficultyMultipliers() //applying the tuple here as the return data type
    {
        float healthMultiplier = 1.0f;
        float strengthMultiplier = 1.0f;

        if (difficultySetting == DifficultyEnum.Normal)
        {
            strengthMultiplier = 1.0f;
            healthMultiplier = 1.0f;
        }

        else if (difficultySetting == DifficultyEnum.Hard)
        {
            strengthMultiplier = 1.2f;
            healthMultiplier = 1.3f;
        }

        return (healthMultiplier, strengthMultiplier);

    }

    //I used to have two separate methods for each stat multiplier but I learnt that by returning with a tuple data type I am able to condense this down into a single method
}
