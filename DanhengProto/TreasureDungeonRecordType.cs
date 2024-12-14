using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200139F RID: 5023
	public enum TreasureDungeonRecordType
	{
		// Token: 0x0400593C RID: 22844
		[OriginalName("TREASURE_DUNGEON_RECORD_NONE")]
		TreasureDungeonRecordNone,
		// Token: 0x0400593D RID: 22845
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_HP")]
		TreasureDungeonRecordAddHp,
		// Token: 0x0400593E RID: 22846
		[OriginalName("TREASURE_DUNGEON_RECORD_SUB_HP")]
		TreasureDungeonRecordSubHp,
		// Token: 0x0400593F RID: 22847
		[OriginalName("TREASURE_DUNGEON_RECORD_SUB_HP_NO_EXPLORE")]
		TreasureDungeonRecordSubHpNoExplore,
		// Token: 0x04005940 RID: 22848
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_ATTACK")]
		TreasureDungeonRecordAddAttack = 5,
		// Token: 0x04005941 RID: 22849
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_DEFENCE")]
		TreasureDungeonRecordAddDefence,
		// Token: 0x04005942 RID: 22850
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_EXPLORE")]
		TreasureDungeonRecordAddExplore = 9,
		// Token: 0x04005943 RID: 22851
		[OriginalName("TREASURE_DUNGEON_RECORD_SUB_EXPLORE")]
		TreasureDungeonRecordSubExplore,
		// Token: 0x04005944 RID: 22852
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_EXPLORE_OVERFLOW")]
		TreasureDungeonRecordAddExploreOverflow,
		// Token: 0x04005945 RID: 22853
		[OriginalName("TREASURE_DUNGEON_RECORD_SUMMON")]
		TreasureDungeonRecordSummon = 15,
		// Token: 0x04005946 RID: 22854
		[OriginalName("TREASURE_DUNGEON_RECORD_KILL")]
		TreasureDungeonRecordKill,
		// Token: 0x04005947 RID: 22855
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_TRIAL_AVATAR")]
		TreasureDungeonRecordAddTrialAvatar = 20,
		// Token: 0x04005948 RID: 22856
		[OriginalName("TREASURE_DUNGEON_RECORD_ADD_BUFF")]
		TreasureDungeonRecordAddBuff = 24,
		// Token: 0x04005949 RID: 22857
		[OriginalName("TREASURE_DUNGEON_RECORD_UNLOCK_DOOR")]
		TreasureDungeonRecordUnlockDoor,
		// Token: 0x0400594A RID: 22858
		[OriginalName("TREASURE_DUNGEON_RECORD_ENEMY_ENHANCE")]
		TreasureDungeonRecordEnemyEnhance = 27,
		// Token: 0x0400594B RID: 22859
		[OriginalName("TREASURE_DUNGEON_RECORD_ENEMY_WEAKEN")]
		TreasureDungeonRecordEnemyWeaken,
		// Token: 0x0400594C RID: 22860
		[OriginalName("TREASURE_DUNGEON_RECORD_ENEMY_AURA_REMOVE")]
		TreasureDungeonRecordEnemyAuraRemove,
		// Token: 0x0400594D RID: 22861
		[OriginalName("TREASURE_DUNGEON_RECORD_SPECIAL_MONSTER_RUN")]
		TreasureDungeonRecordSpecialMonsterRun,
		// Token: 0x0400594E RID: 22862
		[OriginalName("TREASURE_DUNGEON_RECORD_SPECIAL_MONSTER_KILL")]
		TreasureDungeonRecordSpecialMonsterKill,
		// Token: 0x0400594F RID: 22863
		[OriginalName("TREASURE_DUNGEON_RECORD_BATTLE_BUFF_TRIGGER_SUCCESS")]
		TreasureDungeonRecordBattleBuffTriggerSuccess = 33,
		// Token: 0x04005950 RID: 22864
		[OriginalName("TREASURE_DUNGEON_RECORD_BATTLE_BUFF_TRIGGER_FAIL")]
		TreasureDungeonRecordBattleBuffTriggerFail,
		// Token: 0x04005951 RID: 22865
		[OriginalName("TREASURE_DUNGEON_RECORD_BATTLE_BUFF_ADD_EXPLORE")]
		TreasureDungeonRecordBattleBuffAddExplore,
		// Token: 0x04005952 RID: 22866
		[OriginalName("TREASURE_DUNGEON_RECORD_BATTLE_BUFF_OPEN_GRID")]
		TreasureDungeonRecordBattleBuffOpenGrid,
		// Token: 0x04005953 RID: 22867
		[OriginalName("TREASURE_DUNGEON_RECORD_BATTLE_BUFF_ADD_ITEM")]
		TreasureDungeonRecordBattleBuffAddItem,
		// Token: 0x04005954 RID: 22868
		[OriginalName("TREASURE_DUNGEON_RECORD_AVATAR_DEAD")]
		TreasureDungeonRecordAvatarDead = 40,
		// Token: 0x04005955 RID: 22869
		[OriginalName("TREASURE_DUNGEON_RECORD_TRIAL_AVATAR_DEAD")]
		TreasureDungeonRecordTrialAvatarDead,
		// Token: 0x04005956 RID: 22870
		[OriginalName("TREASURE_DUNGEON_RECORD_ALL_AVATAR_DEAD")]
		TreasureDungeonRecordAllAvatarDead,
		// Token: 0x04005957 RID: 22871
		[OriginalName("TREASURE_DUNGEON_RECORD_OPEN_ITEM_CHEST")]
		TreasureDungeonRecordOpenItemChest
	}
}
