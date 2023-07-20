using System;

public class EnemyTankController
{
    private EnemyTankModel enemyTankModel;
    private EnemyTankView enemyTankView;
    public EnemyTankController(EnemyTankModel enemyTankModel, EnemyTankView enemyTankView)
    {
        this.enemyTankModel = enemyTankModel;
        this.enemyTankView = enemyTankView;

        this.enemyTankModel.EnemyTankController = this;
        this.enemyTankView.EnemyTankController = this;
    }

    public void OnDisable()
    {
        enemyTankView.Disable();
    }

    internal void Enable()
    {
        enemyTankView.Enabled();
    }
}