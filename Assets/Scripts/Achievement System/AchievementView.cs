using UnityEngine;

public class AchievementView : MonoBehaviour
{
    AchievementModel achievementModel;

   public AchievementView(AchievementModel achievementModel)
    {
        this.achievementModel = achievementModel;
    }

    public void ShotFired()
    {
        achievementModel.NShotsFired++;
        if(achievementModel.NShotsFired % 10 == 0)
        {
            EventService.Instance.InvokeShotsFiredAction(achievementModel.NShotsFired);
        }
    }

    public void EnemyDestroyed()
    {
        achievementModel.NEnemiesDestroyed++;

        if (achievementModel.NEnemiesDestroyed % 5 == 0)
        {
            EventService.Instance.InvokeEnemiesDestroyedAction(achievementModel.NEnemiesDestroyed);
            //GameAudioService.Instance.PlayAudio(GameAudio.SoundType.Explosion);
        }
    }
}
