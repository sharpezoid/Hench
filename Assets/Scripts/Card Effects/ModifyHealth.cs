using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Modify Health Effect", menuName = "New Modify Health Effect")]
public class ModifyHealth : BaseEffect
{
    public int health;

    public override void Play(Unit _target)
    {
        if (health > 0)
            _target.Health.Heal(health);
        else
            _target.Health.Damage(health);
    }
}
