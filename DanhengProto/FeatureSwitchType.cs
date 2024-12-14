using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000513 RID: 1299
	public enum FeatureSwitchType
	{
		// Token: 0x04001730 RID: 5936
		[OriginalName("FEATURE_SWITCH_NONE")]
		FeatureSwitchNone,
		// Token: 0x04001731 RID: 5937
		[OriginalName("FEATURE_SWITCH_SHOP")]
		FeatureSwitchShop,
		// Token: 0x04001732 RID: 5938
		[OriginalName("FEATURE_SWITCH_LINEUP_NAME")]
		FeatureSwitchLineupName,
		// Token: 0x04001733 RID: 5939
		[OriginalName("FEATURE_SWITCH_RECHARGE_SHOP")]
		FeatureSwitchRechargeShop,
		// Token: 0x04001734 RID: 5940
		[OriginalName("FEATURE_SWITCH_NICKNAME")]
		FeatureSwitchNickname,
		// Token: 0x04001735 RID: 5941
		[OriginalName("FEATURE_SWITCH_SIGNATURE")]
		FeatureSwitchSignature,
		// Token: 0x04001736 RID: 5942
		[OriginalName("FEATURE_SWITCH_BATTLEPASS")]
		FeatureSwitchBattlepass,
		// Token: 0x04001737 RID: 5943
		[OriginalName("FEATURE_SWITCH_PUNK_LORD")]
		FeatureSwitchPunkLord,
		// Token: 0x04001738 RID: 5944
		[OriginalName("FEATURE_SWITCH_MONTHCARD_DAILY")]
		FeatureSwitchMonthcardDaily,
		// Token: 0x04001739 RID: 5945
		[OriginalName("FEATURE_SWITCH_PICTURE_SHARE")]
		FeatureSwitchPictureShare,
		// Token: 0x0400173A RID: 5946
		[OriginalName("FEATURE_SWITCH_ROGUE")]
		FeatureSwitchRogue,
		// Token: 0x0400173B RID: 5947
		[OriginalName("FEATURE_SWITCH_CHALLENGE")]
		FeatureSwitchChallenge,
		// Token: 0x0400173C RID: 5948
		[OriginalName("FEATURE_SWITCH_COCOON")]
		FeatureSwitchCocoon,
		// Token: 0x0400173D RID: 5949
		[OriginalName("FEATURE_SWITCH_RAID")]
		FeatureSwitchRaid,
		// Token: 0x0400173E RID: 5950
		[OriginalName("FEATURE_SWITCH_MAZE_PLANE_EVENT")]
		FeatureSwitchMazePlaneEvent,
		// Token: 0x0400173F RID: 5951
		[OriginalName("FEATURE_SWITCH_ACTIVITY_PANEL")]
		FeatureSwitchActivityPanel,
		// Token: 0x04001740 RID: 5952
		[OriginalName("FEATURE_SWITCH_MAILBOX")]
		FeatureSwitchMailbox,
		// Token: 0x04001741 RID: 5953
		[OriginalName("FEATURE_SWITCH_QUEST")]
		FeatureSwitchQuest,
		// Token: 0x04001742 RID: 5954
		[OriginalName("FEATURE_SWITCH_GACHA")]
		FeatureSwitchGacha,
		// Token: 0x04001743 RID: 5955
		[OriginalName("FEATURE_SWITCH_CHAT")]
		FeatureSwitchChat,
		// Token: 0x04001744 RID: 5956
		[OriginalName("FEATURE_SWITCH_MODIFY_FRIEND_ALIAS")]
		FeatureSwitchModifyFriendAlias,
		// Token: 0x04001745 RID: 5957
		[OriginalName("FEATURE_SWITCH_USE_ITEM")]
		FeatureSwitchUseItem,
		// Token: 0x04001746 RID: 5958
		[OriginalName("FEATURE_SWITCH_ACTIVITY_SCHEDULE")]
		FeatureSwitchActivitySchedule,
		// Token: 0x04001747 RID: 5959
		[OriginalName("FEATURE_SWITCH_FARM_ELEMENT")]
		FeatureSwitchFarmElement,
		// Token: 0x04001748 RID: 5960
		[OriginalName("FEATURE_SWITCH_ACHIEVEMENT_LEVEL")]
		FeatureSwitchAchievementLevel,
		// Token: 0x04001749 RID: 5961
		[OriginalName("FEATURE_SWITCH_DAILY_ACTIVE_LEVEL")]
		FeatureSwitchDailyActiveLevel,
		// Token: 0x0400174A RID: 5962
		[OriginalName("FEATURE_SWITCH_PLAYER_RETURN")]
		FeatureSwitchPlayerReturn,
		// Token: 0x0400174B RID: 5963
		[OriginalName("FEATURE_SWITCH_FIRST_SET_NICKNAME")]
		FeatureSwitchFirstSetNickname,
		// Token: 0x0400174C RID: 5964
		[OriginalName("FEATURE_SWITCH_MAIN_MISSION_REWARD")]
		FeatureSwitchMainMissionReward,
		// Token: 0x0400174D RID: 5965
		[OriginalName("FEATURE_SWITCH_SUB_MISSION_REWARD")]
		FeatureSwitchSubMissionReward,
		// Token: 0x0400174E RID: 5966
		[OriginalName("FEATURE_SWITCH_PAM_MISSION")]
		FeatureSwitchPamMission,
		// Token: 0x0400174F RID: 5967
		[OriginalName("FEATURE_SWITCH_DAILY_MISSION")]
		FeatureSwitchDailyMission,
		// Token: 0x04001750 RID: 5968
		[OriginalName("FEATURE_SWITCH_DESTROY_ITEM")]
		FeatureSwitchDestroyItem,
		// Token: 0x04001751 RID: 5969
		[OriginalName("FEATURE_SWITCH_CONSUME_ITEM_TURN")]
		FeatureSwitchConsumeItemTurn,
		// Token: 0x04001752 RID: 5970
		[OriginalName("FEATURE_SWITCH_ROGUE_MODIFIER")]
		FeatureSwitchRogueModifier,
		// Token: 0x04001753 RID: 5971
		[OriginalName("FEATURE_SWITCH_CHESS_ROGUE")]
		FeatureSwitchChessRogue,
		// Token: 0x04001754 RID: 5972
		[OriginalName("FEATURE_SWITCH_CHESS_ROGUE_BOARD")]
		FeatureSwitchChessRogueBoard,
		// Token: 0x04001755 RID: 5973
		[OriginalName("FEATURE_SWITCH_ROLL_SHOP")]
		FeatureSwitchRollShop,
		// Token: 0x04001756 RID: 5974
		[OriginalName("FEATURE_SWITCH_H5_RETURN")]
		FeatureSwitchH5Return,
		// Token: 0x04001757 RID: 5975
		[OriginalName("FEATURE_SWITCH_OFFERING")]
		FeatureSwitchOffering,
		// Token: 0x04001758 RID: 5976
		[OriginalName("FEATURE_SWITCH_SERVER_RED_POINT")]
		FeatureSwitchServerRedPoint,
		// Token: 0x04001759 RID: 5977
		[OriginalName("FEATURE_SWITCH_MONOPOLY_OPTION_RATIO")]
		FeatureSwitchMonopolyOptionRatio,
		// Token: 0x0400175A RID: 5978
		[OriginalName("FEATURE_SWITCH_MONOPOLY_GET_RAFFLE_TICKET")]
		FeatureSwitchMonopolyGetRaffleTicket,
		// Token: 0x0400175B RID: 5979
		[OriginalName("FEATURE_SWITCH_MONOPOLY_TAKE_RAFFLE_REWARD")]
		FeatureSwitchMonopolyTakeRaffleReward,
		// Token: 0x0400175C RID: 5980
		[OriginalName("FEATURE_SWITCH_CHALLENGE_RECOMMEND_LINEUP")]
		FeatureSwitchChallengeRecommendLineup,
		// Token: 0x0400175D RID: 5981
		[OriginalName("FEATURE_SWITCH_PSN_MEMBER_SHIP_CHECK")]
		FeatureSwitchPsnMemberShipCheck,
		// Token: 0x0400175E RID: 5982
		[OriginalName("FEATURE_SWITCH_PLAYER_BOARD_DEVELOPMENT")]
		FeatureSwitchPlayerBoardDevelopment,
		// Token: 0x0400175F RID: 5983
		[OriginalName("FEATURE_SWITCH_PVP")]
		FeatureSwitchPvp,
		// Token: 0x04001760 RID: 5984
		[OriginalName("FEATURE_SWITCH_ROGUE_MODE")]
		FeatureSwitchRogueMode,
		// Token: 0x04001761 RID: 5985
		[OriginalName("FEATURE_SWITCH_ROGUE_TOURN_UGC")]
		FeatureSwitchRogueTournUgc,
		// Token: 0x04001762 RID: 5986
		[OriginalName("FEATURE_SWITCH_RELIC_FILTER_PLAN_NAME")]
		FeatureSwitchRelicFilterPlanName,
		// Token: 0x04001763 RID: 5987
		[OriginalName("FEATURE_SWITCH_MAZE_ITEM_USE_BUFF_DROP")]
		FeatureSwitchMazeItemUseBuffDrop,
		// Token: 0x04001764 RID: 5988
		[OriginalName("FEATURE_SWITCH_RED_DOT")]
		FeatureSwitchRedDot,
		// Token: 0x04001765 RID: 5989
		[OriginalName("FEATURE_SWITCH_GAME_STATE_SERVICE")]
		FeatureSwitchGameStateService
	}
}
