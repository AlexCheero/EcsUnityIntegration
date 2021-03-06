using ECS;
using UnityEngine;

[CreateAssetMenu(fileName = "EntityPreset", menuName = "ECS/New entity preset", order = -1)]
public class EntityPreset : ScriptableObject
{
    [SerializeField]
    public EntityMeta Data = new EntityMeta { Metas = new ComponentMeta[0] };

    public int InitAsEntity(EcsWorld world) => IntegrationHelper.InitAsEntity(world, Data);
}
