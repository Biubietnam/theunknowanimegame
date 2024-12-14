using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000103 RID: 259
	public enum BattleStaticticEventType
	{
		// Token: 0x040004DF RID: 1247
		[OriginalName("BATTLE_STATICTIC_EVENT_NONE")]
		BattleStaticticEventNone,
		// Token: 0x040004E0 RID: 1248
		[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_ADD_EXPLORE")]
		BattleStaticticEventTreasureDungeonAddExplore,
		// Token: 0x040004E1 RID: 1249
		[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_OPEN_GRID")]
		BattleStaticticEventTreasureDungeonOpenGrid,
		// Token: 0x040004E2 RID: 1250
		[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_PICKUP_ITEM")]
		BattleStaticticEventTreasureDungeonPickupItem,
		// Token: 0x040004E3 RID: 1251
		[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_USE_BUFF")]
		BattleStaticticEventTreasureDungeonUseBuff,
		// Token: 0x040004E4 RID: 1252
		[OriginalName("BATTLE_STATICTIC_EVENT_TELEVISION_ACTIVITY_UPDATE_MAZE_BUFF_LAYER")]
		BattleStaticticEventTelevisionActivityUpdateMazeBuffLayer
	}
}
