using System.Collections.Generic;

public class PoolConfig
{
    public List<PoolData> Data = new List<PoolData>
    {
        new PoolData
        {
            Path = Paths.PREFAB_BULLET,
            PreloadCount = 15,
            AutoDestroy = false
        },
        new PoolData
        {
            Path = Paths.PREFAB_PLANE,
            PreloadCount = 15,
            AutoDestroy = false
        },
        new PoolData
        {
            Path = Paths.PREFAB_ITEM_ITEM,
            PreloadCount = 10,
            AutoDestroy = false
        },
        new PoolData
        {
            Path = Paths.EFFECT_FRAME_ANI,
            PreloadCount = 15,
            AutoDestroy = false
        },
        new PoolData
        {
            Path = Paths.PREFAB_ENEMY_MISSILE,
            PreloadCount = 3,
            AutoDestroy = true
        },
        new PoolData
        {
            Path = Paths.PREFAB_ITEM_LIGHT,
            PreloadCount = 3,
            AutoDestroy = true
        }
    };
}

public class PoolData
{
    public string Path { get; set; }
    public int PreloadCount { get; set; }
    public bool AutoDestroy { get; set; }
}