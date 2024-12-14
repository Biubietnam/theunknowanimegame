using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD5 RID: 3541
	public enum Retcode
	{
		// Token: 0x04003D80 RID: 15744
		[OriginalName("RET_SUCC")]
		RetSucc,
		// Token: 0x04003D81 RID: 15745
		[OriginalName("RET_FAIL")]
		RetFail,
		// Token: 0x04003D82 RID: 15746
		[OriginalName("RET_SERVER_INTERNAL_ERROR")]
		RetServerInternalError,
		// Token: 0x04003D83 RID: 15747
		[OriginalName("RET_TIMEOUT")]
		RetTimeout,
		// Token: 0x04003D84 RID: 15748
		[OriginalName("RET_REPEATED_REQ")]
		RetRepeatedReq,
		// Token: 0x04003D85 RID: 15749
		[OriginalName("RET_REQ_PARA_INVALID")]
		RetReqParaInvalid,
		// Token: 0x04003D86 RID: 15750
		[OriginalName("RET_PLAYER_DATA_ERROR")]
		RetPlayerDataError,
		// Token: 0x04003D87 RID: 15751
		[OriginalName("RET_PLAYER_CLIENT_PAUSED")]
		RetPlayerClientPaused,
		// Token: 0x04003D88 RID: 15752
		[OriginalName("RET_FUNC_CHECK_FAILED")]
		RetFuncCheckFailed,
		// Token: 0x04003D89 RID: 15753
		[OriginalName("RET_FEATURE_SWITCH_CLOSED")]
		RetFeatureSwitchClosed,
		// Token: 0x04003D8A RID: 15754
		[OriginalName("RET_FREQ_OVER_LIMIT")]
		RetFreqOverLimit,
		// Token: 0x04003D8B RID: 15755
		[OriginalName("RET_SYSTEM_BUSY")]
		RetSystemBusy,
		// Token: 0x04003D8C RID: 15756
		[OriginalName("RET_PLAYER_NOT_ONLINE")]
		RetPlayerNotOnline,
		// Token: 0x04003D8D RID: 15757
		[OriginalName("RET_REPEATE_LOGIN")]
		RetRepeateLogin = 1000,
		// Token: 0x04003D8E RID: 15758
		[OriginalName("RET_RETRY_LOGIN")]
		RetRetryLogin,
		// Token: 0x04003D8F RID: 15759
		[OriginalName("RET_WAIT_LOGIN")]
		RetWaitLogin,
		// Token: 0x04003D90 RID: 15760
		[OriginalName("RET_NOT_IN_WHITE_LIST")]
		RetNotInWhiteList,
		// Token: 0x04003D91 RID: 15761
		[OriginalName("RET_IN_BLACK_LIST")]
		RetInBlackList,
		// Token: 0x04003D92 RID: 15762
		[OriginalName("RET_ACCOUNT_VERIFY_ERROR")]
		RetAccountVerifyError,
		// Token: 0x04003D93 RID: 15763
		[OriginalName("RET_ACCOUNT_PARA_ERROR")]
		RetAccountParaError,
		// Token: 0x04003D94 RID: 15764
		[OriginalName("RET_ANTI_ADDICT_LOGIN")]
		RetAntiAddictLogin,
		// Token: 0x04003D95 RID: 15765
		[OriginalName("RET_CHECK_SUM_ERROR")]
		RetCheckSumError,
		// Token: 0x04003D96 RID: 15766
		[OriginalName("RET_REACH_MAX_PLAYER_NUM")]
		RetReachMaxPlayerNum,
		// Token: 0x04003D97 RID: 15767
		[OriginalName("RET_ALREADY_REGISTERED")]
		RetAlreadyRegistered,
		// Token: 0x04003D98 RID: 15768
		[OriginalName("RET_GENDER_ERROR")]
		RetGenderError,
		// Token: 0x04003D99 RID: 15769
		[OriginalName("SET_NICKNAME_RET_CALLBACK_PROCESSING")]
		SetNicknameRetCallbackProcessing,
		// Token: 0x04003D9A RID: 15770
		[OriginalName("RET_IN_GM_BIND_ACCESS")]
		RetInGmBindAccess,
		// Token: 0x04003D9B RID: 15771
		[OriginalName("RET_QUEST_REWARD_ALREADY_TAKEN")]
		RetQuestRewardAlreadyTaken = 1100,
		// Token: 0x04003D9C RID: 15772
		[OriginalName("RET_QUEST_NOT_ACCEPT")]
		RetQuestNotAccept,
		// Token: 0x04003D9D RID: 15773
		[OriginalName("RET_QUEST_NOT_FINISH")]
		RetQuestNotFinish,
		// Token: 0x04003D9E RID: 15774
		[OriginalName("RET_QUEST_STATUS_ERROR")]
		RetQuestStatusError,
		// Token: 0x04003D9F RID: 15775
		[OriginalName("RET_ACHIEVEMENT_LEVEL_NOT_REACH")]
		RetAchievementLevelNotReach,
		// Token: 0x04003DA0 RID: 15776
		[OriginalName("RET_ACHIEVEMENT_LEVEL_ALREADY_TAKEN")]
		RetAchievementLevelAlreadyTaken,
		// Token: 0x04003DA1 RID: 15777
		[OriginalName("RET_AVATAR_NOT_EXIST")]
		RetAvatarNotExist = 1200,
		// Token: 0x04003DA2 RID: 15778
		[OriginalName("RET_AVATAR_RES_EXP_NOT_ENOUGH")]
		RetAvatarResExpNotEnough,
		// Token: 0x04003DA3 RID: 15779
		[OriginalName("RET_AVATAR_EXP_REACH_PROMOTION_LIMIT")]
		RetAvatarExpReachPromotionLimit,
		// Token: 0x04003DA4 RID: 15780
		[OriginalName("RET_AVATAR_REACH_MAX_PROMOTION")]
		RetAvatarReachMaxPromotion,
		// Token: 0x04003DA5 RID: 15781
		[OriginalName("RET_SKILLTREE_CONFIG_NOT_EXIST")]
		RetSkilltreeConfigNotExist,
		// Token: 0x04003DA6 RID: 15782
		[OriginalName("RET_SKILLTREE_ALREADY_UNLOCK")]
		RetSkilltreeAlreadyUnlock,
		// Token: 0x04003DA7 RID: 15783
		[OriginalName("RET_SKILLTREE_PRE_LOCKED")]
		RetSkilltreePreLocked,
		// Token: 0x04003DA8 RID: 15784
		[OriginalName("RET_SKILLTREE_LEVEL_NOT_MEET")]
		RetSkilltreeLevelNotMeet,
		// Token: 0x04003DA9 RID: 15785
		[OriginalName("RET_SKILLTREE_RANK_NOT_MEET")]
		RetSkilltreeRankNotMeet,
		// Token: 0x04003DAA RID: 15786
		[OriginalName("RET_AVATAR_DRESS_NO_EQUIPMENT")]
		RetAvatarDressNoEquipment,
		// Token: 0x04003DAB RID: 15787
		[OriginalName("RET_AVATAR_EXP_ITEM_NOT_EXIST")]
		RetAvatarExpItemNotExist,
		// Token: 0x04003DAC RID: 15788
		[OriginalName("RET_SKILLTREE_POINT_LOCKED")]
		RetSkilltreePointLocked,
		// Token: 0x04003DAD RID: 15789
		[OriginalName("RET_SKILLTREE_POINT_LEVEL_UPGRADE_NOT_MATCH")]
		RetSkilltreePointLevelUpgradeNotMatch,
		// Token: 0x04003DAE RID: 15790
		[OriginalName("RET_SKILLTREE_POINT_LEVEL_REACH_MAX")]
		RetSkilltreePointLevelReachMax,
		// Token: 0x04003DAF RID: 15791
		[OriginalName("RET_WORLD_LEVEL_NOT_MEET")]
		RetWorldLevelNotMeet,
		// Token: 0x04003DB0 RID: 15792
		[OriginalName("RET_PLAYER_LEVEL_NOT_MEET")]
		RetPlayerLevelNotMeet,
		// Token: 0x04003DB1 RID: 15793
		[OriginalName("RET_AVATAR_RANK_NOT_MATCH")]
		RetAvatarRankNotMatch,
		// Token: 0x04003DB2 RID: 15794
		[OriginalName("RET_AVATAR_RANK_REACH_MAX")]
		RetAvatarRankReachMax,
		// Token: 0x04003DB3 RID: 15795
		[OriginalName("RET_HERO_BASIC_TYPE_NOT_MATCH")]
		RetHeroBasicTypeNotMatch,
		// Token: 0x04003DB4 RID: 15796
		[OriginalName("RET_AVATAR_PROMOTION_NOT_MEET")]
		RetAvatarPromotionNotMeet,
		// Token: 0x04003DB5 RID: 15797
		[OriginalName("RET_PROMOTION_REWARD_CONFIG_NOT_EXIST")]
		RetPromotionRewardConfigNotExist,
		// Token: 0x04003DB6 RID: 15798
		[OriginalName("RET_PROMOTION_REWARD_ALREADY_TAKEN")]
		RetPromotionRewardAlreadyTaken,
		// Token: 0x04003DB7 RID: 15799
		[OriginalName("RET_AVATAR_SKIN_ITEM_NOT_EXIST")]
		RetAvatarSkinItemNotExist,
		// Token: 0x04003DB8 RID: 15800
		[OriginalName("RET_AVATAR_SKIN_ALREADY_DRESSED")]
		RetAvatarSkinAlreadyDressed,
		// Token: 0x04003DB9 RID: 15801
		[OriginalName("RET_AVATAR_NOT_DRESS_SKIN")]
		RetAvatarNotDressSkin,
		// Token: 0x04003DBA RID: 15802
		[OriginalName("RET_AVATAR_SKIN_NOT_MATCH_AVATAR")]
		RetAvatarSkinNotMatchAvatar,
		// Token: 0x04003DBB RID: 15803
		[OriginalName("RET_ITEM_NOT_EXIST")]
		RetItemNotExist = 1300,
		// Token: 0x04003DBC RID: 15804
		[OriginalName("RET_ITEM_COST_NOT_ENOUGH")]
		RetItemCostNotEnough,
		// Token: 0x04003DBD RID: 15805
		[OriginalName("RET_ITEM_COST_TOO_MUCH")]
		RetItemCostTooMuch,
		// Token: 0x04003DBE RID: 15806
		[OriginalName("RET_ITEM_NO_COST")]
		RetItemNoCost,
		// Token: 0x04003DBF RID: 15807
		[OriginalName("RET_ITEM_NOT_ENOUGH")]
		RetItemNotEnough,
		// Token: 0x04003DC0 RID: 15808
		[OriginalName("RET_ITEM_INVALID")]
		RetItemInvalid,
		// Token: 0x04003DC1 RID: 15809
		[OriginalName("RET_ITEM_CONFIG_NOT_EXIST")]
		RetItemConfigNotExist,
		// Token: 0x04003DC2 RID: 15810
		[OriginalName("RET_SCOIN_NOT_ENOUGH")]
		RetScoinNotEnough,
		// Token: 0x04003DC3 RID: 15811
		[OriginalName("RET_ITEM_REWARD_EXCEED_LIMIT")]
		RetItemRewardExceedLimit,
		// Token: 0x04003DC4 RID: 15812
		[OriginalName("RET_ITEM_INVALID_USE")]
		RetItemInvalidUse,
		// Token: 0x04003DC5 RID: 15813
		[OriginalName("RET_ITEM_USE_CONFIG_NOT_EXIST")]
		RetItemUseConfigNotExist,
		// Token: 0x04003DC6 RID: 15814
		[OriginalName("RET_REWARD_CONFIG_NOT_EXIST")]
		RetRewardConfigNotExist,
		// Token: 0x04003DC7 RID: 15815
		[OriginalName("RET_ITEM_EXCEED_LIMIT")]
		RetItemExceedLimit,
		// Token: 0x04003DC8 RID: 15816
		[OriginalName("RET_ITEM_COUNT_INVALID")]
		RetItemCountInvalid,
		// Token: 0x04003DC9 RID: 15817
		[OriginalName("RET_ITEM_USE_TARGET_TYPE_INVALID")]
		RetItemUseTargetTypeInvalid,
		// Token: 0x04003DCA RID: 15818
		[OriginalName("RET_ITEM_USE_SATIETY_FULL")]
		RetItemUseSatietyFull,
		// Token: 0x04003DCB RID: 15819
		[OriginalName("RET_ITEM_COMPOSE_NOT_EXIST")]
		RetItemComposeNotExist,
		// Token: 0x04003DCC RID: 15820
		[OriginalName("RET_RELIC_COMPOSE_NOT_EXIST")]
		RetRelicComposeNotExist,
		// Token: 0x04003DCD RID: 15821
		[OriginalName("RET_ITEM_CAN_NOT_SELL")]
		RetItemCanNotSell,
		// Token: 0x04003DCE RID: 15822
		[OriginalName("RET_ITEM_SELL_EXCEDD_LIMIT")]
		RetItemSellExceddLimit,
		// Token: 0x04003DCF RID: 15823
		[OriginalName("RET_ITEM_NOT_IN_COST_LIST")]
		RetItemNotInCostList,
		// Token: 0x04003DD0 RID: 15824
		[OriginalName("RET_ITEM_SPECIAL_COST_NOT_ENOUGH")]
		RetItemSpecialCostNotEnough,
		// Token: 0x04003DD1 RID: 15825
		[OriginalName("RET_ITEM_SPECIAL_COST_TOO_MUCH")]
		RetItemSpecialCostTooMuch,
		// Token: 0x04003DD2 RID: 15826
		[OriginalName("RET_ITEM_FORMULA_NOT_EXIST")]
		RetItemFormulaNotExist,
		// Token: 0x04003DD3 RID: 15827
		[OriginalName("RET_ITEM_AUTO_GIFT_OPTIONAL_NOT_EXIST")]
		RetItemAutoGiftOptionalNotExist,
		// Token: 0x04003DD4 RID: 15828
		[OriginalName("RET_RELIC_COMPOSE_RELIC_INVALID")]
		RetRelicComposeRelicInvalid,
		// Token: 0x04003DD5 RID: 15829
		[OriginalName("RET_RELIC_COMPOSE_MAIN_AFFIX_ID_INVALID")]
		RetRelicComposeMainAffixIdInvalid,
		// Token: 0x04003DD6 RID: 15830
		[OriginalName("RET_RELIC_COMPOSE_WRONG_FORMULA_TYPE")]
		RetRelicComposeWrongFormulaType,
		// Token: 0x04003DD7 RID: 15831
		[OriginalName("RET_RELIC_COMPOSE_RELIC_NOT_EXIST")]
		RetRelicComposeRelicNotExist,
		// Token: 0x04003DD8 RID: 15832
		[OriginalName("RET_RELIC_COMPOSE_BLACK_GOLD_COUNT_INVALID")]
		RetRelicComposeBlackGoldCountInvalid,
		// Token: 0x04003DD9 RID: 15833
		[OriginalName("RET_RELIC_COMPOSE_BLACK_GOLD_NOT_NEED")]
		RetRelicComposeBlackGoldNotNeed,
		// Token: 0x04003DDA RID: 15834
		[OriginalName("RET_MONTH_CARD_CANNOT_USE")]
		RetMonthCardCannotUse,
		// Token: 0x04003DDB RID: 15835
		[OriginalName("RET_ITEM_REWARD_EXCEED_DISAPPEAR")]
		RetItemRewardExceedDisappear,
		// Token: 0x04003DDC RID: 15836
		[OriginalName("RET_ITEM_NEED_RECYCLE")]
		RetItemNeedRecycle,
		// Token: 0x04003DDD RID: 15837
		[OriginalName("RET_ITEM_COMPOSE_EXCEED_LIMIT")]
		RetItemComposeExceedLimit,
		// Token: 0x04003DDE RID: 15838
		[OriginalName("RET_ITEM_CAN_NOT_DESTROY")]
		RetItemCanNotDestroy,
		// Token: 0x04003DDF RID: 15839
		[OriginalName("RET_ITEM_ALREADY_MARK")]
		RetItemAlreadyMark,
		// Token: 0x04003DE0 RID: 15840
		[OriginalName("RET_ITEM_MARK_EXCEED_LIMIT")]
		RetItemMarkExceedLimit,
		// Token: 0x04003DE1 RID: 15841
		[OriginalName("RET_ITEM_NOT_MARK")]
		RetItemNotMark,
		// Token: 0x04003DE2 RID: 15842
		[OriginalName("RET_ITEN_TURN_FOOD_NOT_SET")]
		RetItenTurnFoodNotSet,
		// Token: 0x04003DE3 RID: 15843
		[OriginalName("RET_ITEM_TURN_FOOD_ALREADY_SET")]
		RetItemTurnFoodAlreadySet,
		// Token: 0x04003DE4 RID: 15844
		[OriginalName("RET_ITEM_TURN_FOOD_CONSUME_TYPE_ERROR")]
		RetItemTurnFoodConsumeTypeError,
		// Token: 0x04003DE5 RID: 15845
		[OriginalName("RET_ITEM_TURN_FOOD_SWITCH_ALREADY_OPEN")]
		RetItemTurnFoodSwitchAlreadyOpen,
		// Token: 0x04003DE6 RID: 15846
		[OriginalName("RET_ITEM_TURN_FOOD_SWITCH_ALREADY_CLOSE")]
		RetItemTurnFoodSwitchAlreadyClose,
		// Token: 0x04003DE7 RID: 15847
		[OriginalName("RET_HCOIN_EXCHANGE_TOO_MUCH")]
		RetHcoinExchangeTooMuch,
		// Token: 0x04003DE8 RID: 15848
		[OriginalName("RET_ITEM_TURN_FOOD_SCENE_TYPE_ERROR")]
		RetItemTurnFoodSceneTypeError,
		// Token: 0x04003DE9 RID: 15849
		[OriginalName("RET_EQUIPMENT_ALREADY_DRESSED")]
		RetEquipmentAlreadyDressed = 1350,
		// Token: 0x04003DEA RID: 15850
		[OriginalName("RET_EQUIPMENT_NOT_EXIST")]
		RetEquipmentNotExist,
		// Token: 0x04003DEB RID: 15851
		[OriginalName("RET_EQUIPMENT_REACH_LEVEL_LIMIT")]
		RetEquipmentReachLevelLimit,
		// Token: 0x04003DEC RID: 15852
		[OriginalName("RET_EQUIPMENT_CONSUME_SELF")]
		RetEquipmentConsumeSelf,
		// Token: 0x04003DED RID: 15853
		[OriginalName("RET_EQUIPMENT_ALREADY_LOCKED")]
		RetEquipmentAlreadyLocked,
		// Token: 0x04003DEE RID: 15854
		[OriginalName("RET_EQUIPMENT_ALREADY_UNLOCKED")]
		RetEquipmentAlreadyUnlocked,
		// Token: 0x04003DEF RID: 15855
		[OriginalName("RET_EQUIPMENT_LOCKED")]
		RetEquipmentLocked,
		// Token: 0x04003DF0 RID: 15856
		[OriginalName("RET_EQUIPMENT_SELECT_NUM_OVER_LIMIT")]
		RetEquipmentSelectNumOverLimit,
		// Token: 0x04003DF1 RID: 15857
		[OriginalName("RET_EQUIPMENT_RANK_UP_MUST_CONSUME_SAME_TID")]
		RetEquipmentRankUpMustConsumeSameTid,
		// Token: 0x04003DF2 RID: 15858
		[OriginalName("RET_EQUIPMENT_PROMOTION_REACH_MAX")]
		RetEquipmentPromotionReachMax,
		// Token: 0x04003DF3 RID: 15859
		[OriginalName("RET_EQUIPMENT_RANK_UP_REACH_MAX")]
		RetEquipmentRankUpReachMax,
		// Token: 0x04003DF4 RID: 15860
		[OriginalName("RET_EQUIPMENT_LEVEL_REACH_MAX")]
		RetEquipmentLevelReachMax,
		// Token: 0x04003DF5 RID: 15861
		[OriginalName("RET_EQUIPMENT_EXCEED_LIMIT")]
		RetEquipmentExceedLimit,
		// Token: 0x04003DF6 RID: 15862
		[OriginalName("RET_RELIC_NOT_EXIST")]
		RetRelicNotExist,
		// Token: 0x04003DF7 RID: 15863
		[OriginalName("RET_RELIC_REACH_LEVEL_LIMIT")]
		RetRelicReachLevelLimit,
		// Token: 0x04003DF8 RID: 15864
		[OriginalName("RET_RELIC_CONSUME_SELF")]
		RetRelicConsumeSelf,
		// Token: 0x04003DF9 RID: 15865
		[OriginalName("RET_RELIC_ALREADY_DRESSED")]
		RetRelicAlreadyDressed,
		// Token: 0x04003DFA RID: 15866
		[OriginalName("RET_RELIC_LOCKED")]
		RetRelicLocked,
		// Token: 0x04003DFB RID: 15867
		[OriginalName("RET_RELIC_ALREADY_LOCKED")]
		RetRelicAlreadyLocked,
		// Token: 0x04003DFC RID: 15868
		[OriginalName("RET_RELIC_ALREADY_UNLOCKED")]
		RetRelicAlreadyUnlocked,
		// Token: 0x04003DFD RID: 15869
		[OriginalName("RET_RELIC_LEVEL_IS_NOT_ZERO")]
		RetRelicLevelIsNotZero,
		// Token: 0x04003DFE RID: 15870
		[OriginalName("RET_UNIQUE_ID_REPEATED")]
		RetUniqueIdRepeated,
		// Token: 0x04003DFF RID: 15871
		[OriginalName("RET_EQUIPMENT_LEVEL_NOT_MEET")]
		RetEquipmentLevelNotMeet,
		// Token: 0x04003E00 RID: 15872
		[OriginalName("RET_EQUIPMENT_ITEM_NOT_IN_COST_LIST")]
		RetEquipmentItemNotInCostList,
		// Token: 0x04003E01 RID: 15873
		[OriginalName("RET_EQUIPMENT_LEVEL_GREATER_THAN_ONE")]
		RetEquipmentLevelGreaterThanOne,
		// Token: 0x04003E02 RID: 15874
		[OriginalName("RET_EQUIPMENT_ALREADY_RANKED")]
		RetEquipmentAlreadyRanked,
		// Token: 0x04003E03 RID: 15875
		[OriginalName("RET_RELIC_EXCEED_LIMIT")]
		RetRelicExceedLimit,
		// Token: 0x04003E04 RID: 15876
		[OriginalName("RET_RELIC_ALREADY_DISCARDED")]
		RetRelicAlreadyDiscarded,
		// Token: 0x04003E05 RID: 15877
		[OriginalName("RET_RELIC_ALREADY_UNDISCARDED")]
		RetRelicAlreadyUndiscarded,
		// Token: 0x04003E06 RID: 15878
		[OriginalName("RET_EQUIPMENT_BATCH_LOCK_TOO_FAST")]
		RetEquipmentBatchLockTooFast,
		// Token: 0x04003E07 RID: 15879
		[OriginalName("RET_RELIC_FILTER_PLAN_SLOT_EMPTY")]
		RetRelicFilterPlanSlotEmpty,
		// Token: 0x04003E08 RID: 15880
		[OriginalName("RET_RELIC_FILTER_PLAN_NUM_EXCEED_LIMIT")]
		RetRelicFilterPlanNumExceedLimit,
		// Token: 0x04003E09 RID: 15881
		[OriginalName("RET_RELIC_FILTER_PLAN_NAME_UTF8_ERROR")]
		RetRelicFilterPlanNameUtf8Error,
		// Token: 0x04003E0A RID: 15882
		[OriginalName("RET_RELIC_FILTER_PLAN_NAME_FORMAT_ERROR")]
		RetRelicFilterPlanNameFormatError,
		// Token: 0x04003E0B RID: 15883
		[OriginalName("RET_RELIC_FILTER_PLAN_NO_CHANGE")]
		RetRelicFilterPlanNoChange,
		// Token: 0x04003E0C RID: 15884
		[OriginalName("RET_LINEUP_INVALID_INDEX")]
		RetLineupInvalidIndex = 1400,
		// Token: 0x04003E0D RID: 15885
		[OriginalName("RET_LINEUP_INVALID_MEMBER_POS")]
		RetLineupInvalidMemberPos,
		// Token: 0x04003E0E RID: 15886
		[OriginalName("RET_LINEUP_SWAP_NOT_EXIST")]
		RetLineupSwapNotExist,
		// Token: 0x04003E0F RID: 15887
		[OriginalName("RET_LINEUP_AVATAR_ALREADY_IN")]
		RetLineupAvatarAlreadyIn,
		// Token: 0x04003E10 RID: 15888
		[OriginalName("RET_LINEUP_CREATE_AVATAR_ERROR")]
		RetLineupCreateAvatarError,
		// Token: 0x04003E11 RID: 15889
		[OriginalName("RET_LINEUP_AVATAR_INIT_ERROR")]
		RetLineupAvatarInitError,
		// Token: 0x04003E12 RID: 15890
		[OriginalName("RET_LINEUP_NOT_EXIST")]
		RetLineupNotExist,
		// Token: 0x04003E13 RID: 15891
		[OriginalName("RET_LINEUP_ONLY_ONE_MEMBER")]
		RetLineupOnlyOneMember,
		// Token: 0x04003E14 RID: 15892
		[OriginalName("RET_LINEUP_SAME_LEADER_SLOT")]
		RetLineupSameLeaderSlot,
		// Token: 0x04003E15 RID: 15893
		[OriginalName("RET_LINEUP_NO_LEADER_SELECT")]
		RetLineupNoLeaderSelect,
		// Token: 0x04003E16 RID: 15894
		[OriginalName("RET_LINEUP_SWAP_SAME_SLOT")]
		RetLineupSwapSameSlot,
		// Token: 0x04003E17 RID: 15895
		[OriginalName("RET_LINEUP_AVATAR_NOT_EXIST")]
		RetLineupAvatarNotExist,
		// Token: 0x04003E18 RID: 15896
		[OriginalName("RET_LINEUP_TRIAL_AVATAR_CAN_NOT_QUIT")]
		RetLineupTrialAvatarCanNotQuit,
		// Token: 0x04003E19 RID: 15897
		[OriginalName("RET_LINEUP_VIRTUAL_LINEUP_PLANE_NOT_MATCH")]
		RetLineupVirtualLineupPlaneNotMatch,
		// Token: 0x04003E1A RID: 15898
		[OriginalName("RET_LINEUP_NOT_VALID_LEADER")]
		RetLineupNotValidLeader,
		// Token: 0x04003E1B RID: 15899
		[OriginalName("RET_LINEUP_SAME_INDEX")]
		RetLineupSameIndex,
		// Token: 0x04003E1C RID: 15900
		[OriginalName("RET_LINEUP_IS_EMPTY")]
		RetLineupIsEmpty,
		// Token: 0x04003E1D RID: 15901
		[OriginalName("RET_LINEUP_NAME_FORMAT_ERROR")]
		RetLineupNameFormatError,
		// Token: 0x04003E1E RID: 15902
		[OriginalName("RET_LINEUP_TYPE_NOT_MATCH")]
		RetLineupTypeNotMatch,
		// Token: 0x04003E1F RID: 15903
		[OriginalName("RET_LINEUP_REPLACE_ALL_FAILED")]
		RetLineupReplaceAllFailed,
		// Token: 0x04003E20 RID: 15904
		[OriginalName("RET_LINEUP_NOT_ALLOW_EDIT")]
		RetLineupNotAllowEdit,
		// Token: 0x04003E21 RID: 15905
		[OriginalName("RET_LINEUP_AVATAR_IS_ALIVE")]
		RetLineupAvatarIsAlive,
		// Token: 0x04003E22 RID: 15906
		[OriginalName("RET_LINEUP_ASSIST_HAS_ONLY_MEMBER")]
		RetLineupAssistHasOnlyMember,
		// Token: 0x04003E23 RID: 15907
		[OriginalName("RET_LINEUP_ASSIST_CANNOT_SWITCH")]
		RetLineupAssistCannotSwitch,
		// Token: 0x04003E24 RID: 15908
		[OriginalName("RET_LINEUP_AVATAR_TYPE_INVALID")]
		RetLineupAvatarTypeInvalid,
		// Token: 0x04003E25 RID: 15909
		[OriginalName("RET_LINEUP_NAME_UTF8_ERROR")]
		RetLineupNameUtf8Error,
		// Token: 0x04003E26 RID: 15910
		[OriginalName("RET_LINEUP_LEADER_LOCK")]
		RetLineupLeaderLock,
		// Token: 0x04003E27 RID: 15911
		[OriginalName("RET_LINEUP_STORY_LINE_NOT_MATCH")]
		RetLineupStoryLineNotMatch,
		// Token: 0x04003E28 RID: 15912
		[OriginalName("RET_LINEUP_AVATAR_LOCK")]
		RetLineupAvatarLock,
		// Token: 0x04003E29 RID: 15913
		[OriginalName("RET_LINEUP_AVATAR_INVALID")]
		RetLineupAvatarInvalid,
		// Token: 0x04003E2A RID: 15914
		[OriginalName("RET_LINEUP_AVATAR_ALREADY_INIT")]
		RetLineupAvatarAlreadyInit,
		// Token: 0x04003E2B RID: 15915
		[OriginalName("RET_LINEUP_LIMITED")]
		RetLineupLimited,
		// Token: 0x04003E2C RID: 15916
		[OriginalName("RET_MAIL_NOT_EXIST")]
		RetMailNotExist = 1700,
		// Token: 0x04003E2D RID: 15917
		[OriginalName("RET_MAIL_RANGE_INVALID")]
		RetMailRangeInvalid,
		// Token: 0x04003E2E RID: 15918
		[OriginalName("RET_MAIL_MAIL_ID_INVALID")]
		RetMailMailIdInvalid,
		// Token: 0x04003E2F RID: 15919
		[OriginalName("RET_MAIL_NO_MAIL_TAKE_ATTACHMENT")]
		RetMailNoMailTakeAttachment,
		// Token: 0x04003E30 RID: 15920
		[OriginalName("RET_MAIL_NO_MAIL_TO_DEL")]
		RetMailNoMailToDel,
		// Token: 0x04003E31 RID: 15921
		[OriginalName("RET_MAIL_TYPE_INVALID")]
		RetMailTypeInvalid,
		// Token: 0x04003E32 RID: 15922
		[OriginalName("RET_MAIL_PARA_INVALID")]
		RetMailParaInvalid,
		// Token: 0x04003E33 RID: 15923
		[OriginalName("RET_MAIL_ATTACHEMENT_INVALID")]
		RetMailAttachementInvalid,
		// Token: 0x04003E34 RID: 15924
		[OriginalName("RET_MAIL_TICKET_INVALID")]
		RetMailTicketInvalid,
		// Token: 0x04003E35 RID: 15925
		[OriginalName("RET_MAIL_TICKET_REPEATED")]
		RetMailTicketRepeated,
		// Token: 0x04003E36 RID: 15926
		[OriginalName("RET_STAGE_SETTLE_ERROR")]
		RetStageSettleError = 1800,
		// Token: 0x04003E37 RID: 15927
		[OriginalName("RET_STAGE_CONFIG_NOT_EXIST")]
		RetStageConfigNotExist,
		// Token: 0x04003E38 RID: 15928
		[OriginalName("RET_STAGE_NOT_FOUND")]
		RetStageNotFound,
		// Token: 0x04003E39 RID: 15929
		[OriginalName("RET_STAGE_COCOON_PROP_NOT_VALID")]
		RetStageCocoonPropNotValid = 1804,
		// Token: 0x04003E3A RID: 15930
		[OriginalName("RET_STAGE_COCOON_WAVE_NOT_VALID")]
		RetStageCocoonWaveNotValid,
		// Token: 0x04003E3B RID: 15931
		[OriginalName("RET_STAGE_PROP_ID_NOT_EQUAL")]
		RetStagePropIdNotEqual,
		// Token: 0x04003E3C RID: 15932
		[OriginalName("RET_STAGE_COCOON_WAVE_OVER")]
		RetStageCocoonWaveOver,
		// Token: 0x04003E3D RID: 15933
		[OriginalName("RET_STAGE_WEEK_COCOON_OVER_CNT")]
		RetStageWeekCocoonOverCnt,
		// Token: 0x04003E3E RID: 15934
		[OriginalName("RET_STAGE_COCOON_NOT_OPEN")]
		RetStageCocoonNotOpen,
		// Token: 0x04003E3F RID: 15935
		[OriginalName("RET_STAGE_TRIAL_NOT_OPEN")]
		RetStageTrialNotOpen,
		// Token: 0x04003E40 RID: 15936
		[OriginalName("RET_STAGE_FARM_NOT_OPEN")]
		RetStageFarmNotOpen,
		// Token: 0x04003E41 RID: 15937
		[OriginalName("RET_STAGE_FARM_TYPE_ERROR")]
		RetStageFarmTypeError,
		// Token: 0x04003E42 RID: 15938
		[OriginalName("RET_CHAPTER_LOCK")]
		RetChapterLock = 1900,
		// Token: 0x04003E43 RID: 15939
		[OriginalName("RET_CHAPTER_CHALLENGE_NUM_NOT_ENOUGH")]
		RetChapterChallengeNumNotEnough,
		// Token: 0x04003E44 RID: 15940
		[OriginalName("RET_CHAPTER_REWARD_ID_NOT_EXIST")]
		RetChapterRewardIdNotExist,
		// Token: 0x04003E45 RID: 15941
		[OriginalName("RET_CHAPTER_REWARD_ALREADY_TAKEN")]
		RetChapterRewardAlreadyTaken,
		// Token: 0x04003E46 RID: 15942
		[OriginalName("RET_BATTLE_STAGE_NOT_MATCH")]
		RetBattleStageNotMatch = 2000,
		// Token: 0x04003E47 RID: 15943
		[OriginalName("RET_IN_BATTLE_NOW")]
		RetInBattleNow,
		// Token: 0x04003E48 RID: 15944
		[OriginalName("RET_BATTLE_CHEAT")]
		RetBattleCheat,
		// Token: 0x04003E49 RID: 15945
		[OriginalName("RET_BATTLE_FAIL")]
		RetBattleFail,
		// Token: 0x04003E4A RID: 15946
		[OriginalName("RET_BATTLE_NO_LINEUP")]
		RetBattleNoLineup,
		// Token: 0x04003E4B RID: 15947
		[OriginalName("RET_BATTLE_LINEUP_EMPTY")]
		RetBattleLineupEmpty,
		// Token: 0x04003E4C RID: 15948
		[OriginalName("RET_BATTLE_VERSION_NOT_MATCH")]
		RetBattleVersionNotMatch,
		// Token: 0x04003E4D RID: 15949
		[OriginalName("RET_BATTLE_QUIT_BY_SERVER")]
		RetBattleQuitByServer,
		// Token: 0x04003E4E RID: 15950
		[OriginalName("RET_IN_BATTLE_CHECK")]
		RetInBattleCheck,
		// Token: 0x04003E4F RID: 15951
		[OriginalName("RET_BATTLE_CHECK_NEED_RETRY")]
		RetBattleCheckNeedRetry,
		// Token: 0x04003E50 RID: 15952
		[OriginalName("RET_BATTLE_COST_TIME_CHECK_FAIL")]
		RetBattleCostTimeCheckFail,
		// Token: 0x04003E51 RID: 15953
		[OriginalName("RET_LACK_EXCHANGE_STAMINA_TIMES")]
		RetLackExchangeStaminaTimes = 2100,
		// Token: 0x04003E52 RID: 15954
		[OriginalName("RET_LACK_STAMINA")]
		RetLackStamina,
		// Token: 0x04003E53 RID: 15955
		[OriginalName("RET_STAMINA_FULL")]
		RetStaminaFull,
		// Token: 0x04003E54 RID: 15956
		[OriginalName("RET_AUTHKEY_SIGN_TYPE_ERROR")]
		RetAuthkeySignTypeError,
		// Token: 0x04003E55 RID: 15957
		[OriginalName("RET_AUTHKEY_SIGN_VER_ERROR")]
		RetAuthkeySignVerError,
		// Token: 0x04003E56 RID: 15958
		[OriginalName("RET_NICKNAME_FORMAT_ERROR")]
		RetNicknameFormatError,
		// Token: 0x04003E57 RID: 15959
		[OriginalName("RET_SENSITIVE_WORDS")]
		RetSensitiveWords,
		// Token: 0x04003E58 RID: 15960
		[OriginalName("RET_LEVEL_REWARD_HAS_TAKEN")]
		RetLevelRewardHasTaken,
		// Token: 0x04003E59 RID: 15961
		[OriginalName("RET_LEVEL_REWARD_LEVEL_ERROR")]
		RetLevelRewardLevelError,
		// Token: 0x04003E5A RID: 15962
		[OriginalName("RET_LANGUAGE_INVALID")]
		RetLanguageInvalid,
		// Token: 0x04003E5B RID: 15963
		[OriginalName("RET_NICKNAME_IN_CD")]
		RetNicknameInCd,
		// Token: 0x04003E5C RID: 15964
		[OriginalName("RET_GAMEPLAY_BIRTHDAY_INVALID")]
		RetGameplayBirthdayInvalid,
		// Token: 0x04003E5D RID: 15965
		[OriginalName("RET_GAMEPLAY_BIRTHDAY_ALREADY_SET")]
		RetGameplayBirthdayAlreadySet,
		// Token: 0x04003E5E RID: 15966
		[OriginalName("RET_NICKNAME_UTF8_ERROR")]
		RetNicknameUtf8Error,
		// Token: 0x04003E5F RID: 15967
		[OriginalName("RET_NICKNAME_DIGIT_LIMIT_ERROR")]
		RetNicknameDigitLimitError,
		// Token: 0x04003E60 RID: 15968
		[OriginalName("RET_SENSITIVE_WORDS_PLATFORM_ERROR")]
		RetSensitiveWordsPlatformError,
		// Token: 0x04003E61 RID: 15969
		[OriginalName("RET_PLAYER_SETTING_TYPE_INVALID")]
		RetPlayerSettingTypeInvalid,
		// Token: 0x04003E62 RID: 15970
		[OriginalName("RET_MAZE_LACK_TICKET")]
		RetMazeLackTicket = 2201,
		// Token: 0x04003E63 RID: 15971
		[OriginalName("RET_MAZE_NOT_UNLOCK")]
		RetMazeNotUnlock,
		// Token: 0x04003E64 RID: 15972
		[OriginalName("RET_MAZE_NO_ABILITY")]
		RetMazeNoAbility = 2204,
		// Token: 0x04003E65 RID: 15973
		[OriginalName("RET_MAZE_NO_PLANE")]
		RetMazeNoPlane,
		// Token: 0x04003E66 RID: 15974
		[OriginalName("RET_MAZE_MAP_NOT_EXIST")]
		RetMazeMapNotExist = 2207,
		// Token: 0x04003E67 RID: 15975
		[OriginalName("RET_MAZE_MP_NOT_ENOUGH")]
		RetMazeMpNotEnough = 2213,
		// Token: 0x04003E68 RID: 15976
		[OriginalName("RET_SPRING_NOT_ENABLE")]
		RetSpringNotEnable,
		// Token: 0x04003E69 RID: 15977
		[OriginalName("RET_SPRING_TOO_FAR")]
		RetSpringTooFar = 2216,
		// Token: 0x04003E6A RID: 15978
		[OriginalName("RET_NOT_IN_MAZE")]
		RetNotInMaze = 2218,
		// Token: 0x04003E6B RID: 15979
		[OriginalName("RET_MAZE_TIME_OF_DAY_TYPE_ERROR")]
		RetMazeTimeOfDayTypeError = 2223,
		// Token: 0x04003E6C RID: 15980
		[OriginalName("RET_SCENE_TRANSFER_LOCKED_BY_TASK")]
		RetSceneTransferLockedByTask,
		// Token: 0x04003E6D RID: 15981
		[OriginalName("RET_PLOT_NOT_UNLOCK")]
		RetPlotNotUnlock = 2300,
		// Token: 0x04003E6E RID: 15982
		[OriginalName("RET_MISSION_NOT_EXIST")]
		RetMissionNotExist = 2400,
		// Token: 0x04003E6F RID: 15983
		[OriginalName("RET_MISSION_ALREADY_DONE")]
		RetMissionAlreadyDone,
		// Token: 0x04003E70 RID: 15984
		[OriginalName("RET_DAILY_TASK_NOT_FINISH")]
		RetDailyTaskNotFinish,
		// Token: 0x04003E71 RID: 15985
		[OriginalName("RET_DAILY_TASK_REWARD_HAS_TAKEN")]
		RetDailyTaskRewardHasTaken,
		// Token: 0x04003E72 RID: 15986
		[OriginalName("RET_MISSION_NOT_FINISH")]
		RetMissionNotFinish,
		// Token: 0x04003E73 RID: 15987
		[OriginalName("RET_MISSION_NOT_DOING")]
		RetMissionNotDoing,
		// Token: 0x04003E74 RID: 15988
		[OriginalName("RET_MISSION_FINISH_WAY_NOT_MATCH")]
		RetMissionFinishWayNotMatch,
		// Token: 0x04003E75 RID: 15989
		[OriginalName("RET_MISSION_SCENE_NOT_MATCH")]
		RetMissionSceneNotMatch,
		// Token: 0x04003E76 RID: 15990
		[OriginalName("RET_MISSION_CUSTOM_VALUE_NOT_VALID")]
		RetMissionCustomValueNotValid,
		// Token: 0x04003E77 RID: 15991
		[OriginalName("RET_MISSION_SUB_MISSION_NOT_MATCH")]
		RetMissionSubMissionNotMatch,
		// Token: 0x04003E78 RID: 15992
		[OriginalName("RET_ADVENTURE_MAP_NOT_EXIST")]
		RetAdventureMapNotExist = 2500,
		// Token: 0x04003E79 RID: 15993
		[OriginalName("RET_SCENE_ENTITY_NOT_EXIST")]
		RetSceneEntityNotExist = 2600,
		// Token: 0x04003E7A RID: 15994
		[OriginalName("RET_NOT_IN_SCENE")]
		RetNotInScene,
		// Token: 0x04003E7B RID: 15995
		[OriginalName("RET_SCENE_MONSTER_NOT_EXIST")]
		RetSceneMonsterNotExist,
		// Token: 0x04003E7C RID: 15996
		[OriginalName("RET_INTERACT_CONFIG_NOT_EXIST")]
		RetInteractConfigNotExist,
		// Token: 0x04003E7D RID: 15997
		[OriginalName("RET_UNSUPPORTED_PROP_STATE")]
		RetUnsupportedPropState,
		// Token: 0x04003E7E RID: 15998
		[OriginalName("RET_SCENE_ENTRY_ID_NOT_MATCH")]
		RetSceneEntryIdNotMatch,
		// Token: 0x04003E7F RID: 15999
		[OriginalName("RET_SCENE_ENTITY_MOVE_CHECK_FAILED")]
		RetSceneEntityMoveCheckFailed,
		// Token: 0x04003E80 RID: 16000
		[OriginalName("RET_ASSIST_MONSTER_COUNT_LIMIT")]
		RetAssistMonsterCountLimit,
		// Token: 0x04003E81 RID: 16001
		[OriginalName("RET_SCENE_USE_SKILL_FAIL")]
		RetSceneUseSkillFail,
		// Token: 0x04003E82 RID: 16002
		[OriginalName("RET_PROP_IS_HIDDEN")]
		RetPropIsHidden,
		// Token: 0x04003E83 RID: 16003
		[OriginalName("RET_LOADING_SUCC_ALREADY")]
		RetLoadingSuccAlready,
		// Token: 0x04003E84 RID: 16004
		[OriginalName("RET_SCENE_ENTITY_TYPE_INVALID")]
		RetSceneEntityTypeInvalid,
		// Token: 0x04003E85 RID: 16005
		[OriginalName("RET_INTERACT_TYPE_INVALID")]
		RetInteractTypeInvalid,
		// Token: 0x04003E86 RID: 16006
		[OriginalName("RET_INTERACT_NOT_IN_REGION")]
		RetInteractNotInRegion,
		// Token: 0x04003E87 RID: 16007
		[OriginalName("RET_INTERACT_SUB_TYPE_INVALID")]
		RetInteractSubTypeInvalid,
		// Token: 0x04003E88 RID: 16008
		[OriginalName("RET_NOT_LEADER_ENTITY")]
		RetNotLeaderEntity,
		// Token: 0x04003E89 RID: 16009
		[OriginalName("RET_MONSTER_IS_NOT_FARM_ELEMENT")]
		RetMonsterIsNotFarmElement,
		// Token: 0x04003E8A RID: 16010
		[OriginalName("RET_MONSTER_CONFIG_NOT_EXIST")]
		RetMonsterConfigNotExist,
		// Token: 0x04003E8B RID: 16011
		[OriginalName("RET_AVATAR_HP_ALREADY_FULL")]
		RetAvatarHpAlreadyFull,
		// Token: 0x04003E8C RID: 16012
		[OriginalName("RET_CUR_INTERACT_ENTITY_NOT_MATCH")]
		RetCurInteractEntityNotMatch,
		// Token: 0x04003E8D RID: 16013
		[OriginalName("RET_PLANE_TYPE_NOT_ALLOW")]
		RetPlaneTypeNotAllow,
		// Token: 0x04003E8E RID: 16014
		[OriginalName("RET_GROUP_NOT_EXIST")]
		RetGroupNotExist,
		// Token: 0x04003E8F RID: 16015
		[OriginalName("RET_GROUP_SAVE_DATA_IN_CD")]
		RetGroupSaveDataInCd,
		// Token: 0x04003E90 RID: 16016
		[OriginalName("RET_GROUP_SAVE_LENGH_REACH_MAX")]
		RetGroupSaveLenghReachMax,
		// Token: 0x04003E91 RID: 16017
		[OriginalName("RET_RECENT_ELEMENT_NOT_EXIST")]
		RetRecentElementNotExist,
		// Token: 0x04003E92 RID: 16018
		[OriginalName("RET_RECENT_ELEMENT_STAGE_NOT_MATCH")]
		RetRecentElementStageNotMatch,
		// Token: 0x04003E93 RID: 16019
		[OriginalName("RET_SCENE_POSITION_VERSION_NOT_MATCH")]
		RetScenePositionVersionNotMatch,
		// Token: 0x04003E94 RID: 16020
		[OriginalName("RET_GAMEPLAY_COUNTER_NOT_EXIST")]
		RetGameplayCounterNotExist,
		// Token: 0x04003E95 RID: 16021
		[OriginalName("RET_GAMEPLAY_COUNTER_NOT_ENOUGH")]
		RetGameplayCounterNotEnough,
		// Token: 0x04003E96 RID: 16022
		[OriginalName("RET_GROUP_STATE_NOT_MATCH")]
		RetGroupStateNotMatch,
		// Token: 0x04003E97 RID: 16023
		[OriginalName("RET_SCENE_ENTITY_POS_NOT_MATCH")]
		RetSceneEntityPosNotMatch,
		// Token: 0x04003E98 RID: 16024
		[OriginalName("RET_GROUP_STATE_CUSTOM_SAVE_DATA_OFF")]
		RetGroupStateCustomSaveDataOff,
		// Token: 0x04003E99 RID: 16025
		[OriginalName("RET_SCENE_NOT_MATCH")]
		RetSceneNotMatch,
		// Token: 0x04003E9A RID: 16026
		[OriginalName("RET_BUY_TIMES_LIMIT")]
		RetBuyTimesLimit = 2700,
		// Token: 0x04003E9B RID: 16027
		[OriginalName("RET_BUY_LIMIT_TYPE")]
		RetBuyLimitType,
		// Token: 0x04003E9C RID: 16028
		[OriginalName("RET_SHOP_NOT_OPEN")]
		RetShopNotOpen,
		// Token: 0x04003E9D RID: 16029
		[OriginalName("RET_GOODS_NOT_OPEN")]
		RetGoodsNotOpen,
		// Token: 0x04003E9E RID: 16030
		[OriginalName("RET_CITY_LEVEL_REWARD_TAKEN")]
		RetCityLevelRewardTaken,
		// Token: 0x04003E9F RID: 16031
		[OriginalName("RET_CITY_LEVEL_NOT_MEET")]
		RetCityLevelNotMeet,
		// Token: 0x04003EA0 RID: 16032
		[OriginalName("RET_SINGLE_BUY_LIMIT")]
		RetSingleBuyLimit,
		// Token: 0x04003EA1 RID: 16033
		[OriginalName("RET_TUTORIAL_NOT_UNLOCK")]
		RetTutorialNotUnlock = 2751,
		// Token: 0x04003EA2 RID: 16034
		[OriginalName("RET_TUTORIAL_UNLOCK_ALREADY")]
		RetTutorialUnlockAlready,
		// Token: 0x04003EA3 RID: 16035
		[OriginalName("RET_TUTORIAL_FINISH_ALREADY")]
		RetTutorialFinishAlready,
		// Token: 0x04003EA4 RID: 16036
		[OriginalName("RET_TUTORIAL_PRE_NOT_UNLOCK")]
		RetTutorialPreNotUnlock,
		// Token: 0x04003EA5 RID: 16037
		[OriginalName("RET_TUTORIAL_PLAYER_LEVEL_NOT_MATCH")]
		RetTutorialPlayerLevelNotMatch,
		// Token: 0x04003EA6 RID: 16038
		[OriginalName("RET_TUTORIAL_TUTORIAL_NOT_FOUND")]
		RetTutorialTutorialNotFound,
		// Token: 0x04003EA7 RID: 16039
		[OriginalName("RET_CHALLENGE_NOT_EXIST")]
		RetChallengeNotExist = 2801,
		// Token: 0x04003EA8 RID: 16040
		[OriginalName("RET_CHALLENGE_NOT_UNLOCK")]
		RetChallengeNotUnlock,
		// Token: 0x04003EA9 RID: 16041
		[OriginalName("RET_CHALLENGE_ALREADY")]
		RetChallengeAlready,
		// Token: 0x04003EAA RID: 16042
		[OriginalName("RET_CHALLENGE_LINEUP_EDIT_FORBIDDEN")]
		RetChallengeLineupEditForbidden,
		// Token: 0x04003EAB RID: 16043
		[OriginalName("RET_CHALLENGE_LINEUP_EMPTY")]
		RetChallengeLineupEmpty,
		// Token: 0x04003EAC RID: 16044
		[OriginalName("RET_CHALLENGE_NOT_DOING")]
		RetChallengeNotDoing,
		// Token: 0x04003EAD RID: 16045
		[OriginalName("RET_CHALLENGE_NOT_FINISH")]
		RetChallengeNotFinish,
		// Token: 0x04003EAE RID: 16046
		[OriginalName("RET_CHALLENGE_TARGET_NOT_FINISH")]
		RetChallengeTargetNotFinish,
		// Token: 0x04003EAF RID: 16047
		[OriginalName("RET_CHALLENGE_TARGET_REWARD_TAKEN")]
		RetChallengeTargetRewardTaken,
		// Token: 0x04003EB0 RID: 16048
		[OriginalName("RET_CHALLENGE_TIME_NOT_VALID")]
		RetChallengeTimeNotValid,
		// Token: 0x04003EB1 RID: 16049
		[OriginalName("RET_CHALLENGE_STARS_COUNT_NOT_MEET")]
		RetChallengeStarsCountNotMeet,
		// Token: 0x04003EB2 RID: 16050
		[OriginalName("RET_CHALLENGE_STARS_REWARD_TAKEN")]
		RetChallengeStarsRewardTaken,
		// Token: 0x04003EB3 RID: 16051
		[OriginalName("RET_CHALLENGE_STARS_NOT_EXIST")]
		RetChallengeStarsNotExist,
		// Token: 0x04003EB4 RID: 16052
		[OriginalName("RET_CHALLENGE_CUR_SCENE_NOT_ENTRY_FLOOR")]
		RetChallengeCurSceneNotEntryFloor,
		// Token: 0x04003EB5 RID: 16053
		[OriginalName("RET_CHALLENGE_NO_TEAM_ARCHIVE")]
		RetChallengeNoTeamArchive,
		// Token: 0x04003EB6 RID: 16054
		[OriginalName("RET_CHALLENGE_LINEUP_AVATAR_TYPE_INVALID")]
		RetChallengeLineupAvatarTypeInvalid,
		// Token: 0x04003EB7 RID: 16055
		[OriginalName("RET_CHALLENGE_LINEUP_RECOMMEND_IN_CD")]
		RetChallengeLineupRecommendInCd,
		// Token: 0x04003EB8 RID: 16056
		[OriginalName("RET_BASIC_TYPE_ALREADY")]
		RetBasicTypeAlready = 2850,
		// Token: 0x04003EB9 RID: 16057
		[OriginalName("RET_NO_BASIC_TYPE")]
		RetNoBasicType,
		// Token: 0x04003EBA RID: 16058
		[OriginalName("RET_NOT_CHOOSE_BASIC_TYPE")]
		RetNotChooseBasicType,
		// Token: 0x04003EBB RID: 16059
		[OriginalName("RET_NOT_FUNC_CLOSE")]
		RetNotFuncClose,
		// Token: 0x04003EBC RID: 16060
		[OriginalName("RET_NOT_CHOOSE_GENDER")]
		RetNotChooseGender,
		// Token: 0x04003EBD RID: 16061
		[OriginalName("RET_NOT_REQ_UNLOCK_BASIC_TYPE")]
		RetNotReqUnlockBasicType,
		// Token: 0x04003EBE RID: 16062
		[OriginalName("RET_AVATAR_PATH_LOCKED")]
		RetAvatarPathLocked,
		// Token: 0x04003EBF RID: 16063
		[OriginalName("RET_ROGUE_STATUS_NOT_MATCH")]
		RetRogueStatusNotMatch = 2901,
		// Token: 0x04003EC0 RID: 16064
		[OriginalName("RET_ROGUE_SELECT_BUFF_NOT_EXIST")]
		RetRogueSelectBuffNotExist,
		// Token: 0x04003EC1 RID: 16065
		[OriginalName("RET_ROGUE_COIN_NOT_ENOUGH")]
		RetRogueCoinNotEnough,
		// Token: 0x04003EC2 RID: 16066
		[OriginalName("RET_ROGUE_STAMINA_NOT_ENOUGH")]
		RetRogueStaminaNotEnough,
		// Token: 0x04003EC3 RID: 16067
		[OriginalName("RET_ROGUE_APPRAISAL_COUNT_NOT_ENOUGH")]
		RetRogueAppraisalCountNotEnough,
		// Token: 0x04003EC4 RID: 16068
		[OriginalName("RET_ROGUE_PROP_ALREADY_USED")]
		RetRoguePropAlreadyUsed,
		// Token: 0x04003EC5 RID: 16069
		[OriginalName("RET_ROGUE_RECORD_ALREADY_SAVED")]
		RetRogueRecordAlreadySaved,
		// Token: 0x04003EC6 RID: 16070
		[OriginalName("RET_ROGUE_ROLL_BUFF_MAX_COUNT")]
		RetRogueRollBuffMaxCount,
		// Token: 0x04003EC7 RID: 16071
		[OriginalName("RET_ROGUE_PICK_AVATAR_INVALID")]
		RetRoguePickAvatarInvalid,
		// Token: 0x04003EC8 RID: 16072
		[OriginalName("RET_ROGUE_QUEST_EXPIRE")]
		RetRogueQuestExpire,
		// Token: 0x04003EC9 RID: 16073
		[OriginalName("RET_ROGUE_QUEST_REWARD_ALREADY")]
		RetRogueQuestRewardAlready,
		// Token: 0x04003ECA RID: 16074
		[OriginalName("RET_ROGUE_REVIVE_COUNT_NOT_ENOUGH")]
		RetRogueReviveCountNotEnough,
		// Token: 0x04003ECB RID: 16075
		[OriginalName("RET_ROGUE_AREA_INVALID")]
		RetRogueAreaInvalid,
		// Token: 0x04003ECC RID: 16076
		[OriginalName("RET_ROGUE_SCORE_REWARD_POOL_INVALID")]
		RetRogueScoreRewardPoolInvalid,
		// Token: 0x04003ECD RID: 16077
		[OriginalName("RET_ROGUE_SCORE_REWARD_ROW_INVALID")]
		RetRogueScoreRewardRowInvalid,
		// Token: 0x04003ECE RID: 16078
		[OriginalName("RET_ROGUE_AEON_LEVEL_NOT_MEET")]
		RetRogueAeonLevelNotMeet,
		// Token: 0x04003ECF RID: 16079
		[OriginalName("RET_ROGUE_AEON_LEVEL_REWARD_ALREADY_TAKEN")]
		RetRogueAeonLevelRewardAlreadyTaken,
		// Token: 0x04003ED0 RID: 16080
		[OriginalName("RET_ROGUE_AEON_CONFIG_NOT_EXIST")]
		RetRogueAeonConfigNotExist,
		// Token: 0x04003ED1 RID: 16081
		[OriginalName("RET_ROGUE_TRIAL_AVATAR_INVALID")]
		RetRogueTrialAvatarInvalid,
		// Token: 0x04003ED2 RID: 16082
		[OriginalName("RET_ROGUE_HANDBOOK_REWARD_ALREADY_TAKEN")]
		RetRogueHandbookRewardAlreadyTaken,
		// Token: 0x04003ED3 RID: 16083
		[OriginalName("RET_ROGUE_ROOM_TYPE_NOT_MATCH")]
		RetRogueRoomTypeNotMatch,
		// Token: 0x04003ED4 RID: 16084
		[OriginalName("RET_ROGUE_SHOP_GOOD_NOT_FOUND")]
		RetRogueShopGoodNotFound,
		// Token: 0x04003ED5 RID: 16085
		[OriginalName("RET_ROGUE_SHOP_GOOD_ALREADY_BOUGHT")]
		RetRogueShopGoodAlreadyBought,
		// Token: 0x04003ED6 RID: 16086
		[OriginalName("RET_ROGUE_SHOP_GOOD_ALREADY_OWN")]
		RetRogueShopGoodAlreadyOwn,
		// Token: 0x04003ED7 RID: 16087
		[OriginalName("RET_ROGUE_SHOP_MIRACLE_NOT_EXIST")]
		RetRogueShopMiracleNotExist,
		// Token: 0x04003ED8 RID: 16088
		[OriginalName("RET_ROGUE_SHOP_NOT_EXIST")]
		RetRogueShopNotExist,
		// Token: 0x04003ED9 RID: 16089
		[OriginalName("RET_ROGUE_SHOP_CANNOT_REFRESH")]
		RetRogueShopCannotRefresh,
		// Token: 0x04003EDA RID: 16090
		[OriginalName("RET_ROGUE_SELECT_BUFF_CERTAIN_MISMATCH")]
		RetRogueSelectBuffCertainMismatch,
		// Token: 0x04003EDB RID: 16091
		[OriginalName("RET_MISSION_EVENT_CONFIG_NOT_EXIST")]
		RetMissionEventConfigNotExist = 2951,
		// Token: 0x04003EDC RID: 16092
		[OriginalName("RET_MISSION_EVENT_NOT_CLIENT")]
		RetMissionEventNotClient,
		// Token: 0x04003EDD RID: 16093
		[OriginalName("RET_MISSION_EVENT_FINISHED")]
		RetMissionEventFinished,
		// Token: 0x04003EDE RID: 16094
		[OriginalName("RET_MISSION_EVENT_DOING")]
		RetMissionEventDoing,
		// Token: 0x04003EDF RID: 16095
		[OriginalName("RET_HAS_CHALLENGE_MISSION_EVENT")]
		RetHasChallengeMissionEvent,
		// Token: 0x04003EE0 RID: 16096
		[OriginalName("RET_NOT_CHALLENGE_MISSION_EVENT")]
		RetNotChallengeMissionEvent,
		// Token: 0x04003EE1 RID: 16097
		[OriginalName("RET_GACHA_ID_NOT_EXIST")]
		RetGachaIdNotExist = 3001,
		// Token: 0x04003EE2 RID: 16098
		[OriginalName("RET_GACHA_NUM_INVALID")]
		RetGachaNumInvalid,
		// Token: 0x04003EE3 RID: 16099
		[OriginalName("RET_GACHA_FIRST_GACHA_MUST_ONE")]
		RetGachaFirstGachaMustOne,
		// Token: 0x04003EE4 RID: 16100
		[OriginalName("RET_GACHA_REQ_DUPLICATED")]
		RetGachaReqDuplicated,
		// Token: 0x04003EE5 RID: 16101
		[OriginalName("RET_GACHA_NOT_IN_SCHEDULE")]
		RetGachaNotInSchedule,
		// Token: 0x04003EE6 RID: 16102
		[OriginalName("RET_GACHA_NEWBIE_CLOSE")]
		RetGachaNewbieClose,
		// Token: 0x04003EE7 RID: 16103
		[OriginalName("RET_GACHA_TODAY_LIMITED")]
		RetGachaTodayLimited,
		// Token: 0x04003EE8 RID: 16104
		[OriginalName("RET_GACHA_NOT_SUPPORT")]
		RetGachaNotSupport,
		// Token: 0x04003EE9 RID: 16105
		[OriginalName("RET_GACHA_CEILING_NOT_ENOUGH")]
		RetGachaCeilingNotEnough,
		// Token: 0x04003EEA RID: 16106
		[OriginalName("RET_GACHA_CEILING_CLOSE")]
		RetGachaCeilingClose,
		// Token: 0x04003EEB RID: 16107
		[OriginalName("RET_NOT_IN_RAID")]
		RetNotInRaid = 3101,
		// Token: 0x04003EEC RID: 16108
		[OriginalName("RET_RAID_DOING")]
		RetRaidDoing,
		// Token: 0x04003EED RID: 16109
		[OriginalName("RET_NOT_PROP")]
		RetNotProp,
		// Token: 0x04003EEE RID: 16110
		[OriginalName("RET_RAID_ID_NOT_MATCH")]
		RetRaidIdNotMatch,
		// Token: 0x04003EEF RID: 16111
		[OriginalName("RET_RAID_RESTART_NOT_MATCH")]
		RetRaidRestartNotMatch,
		// Token: 0x04003EF0 RID: 16112
		[OriginalName("RET_RAID_LIMIT")]
		RetRaidLimit,
		// Token: 0x04003EF1 RID: 16113
		[OriginalName("RET_RAID_AVATAR_LIST_EMPTY")]
		RetRaidAvatarListEmpty,
		// Token: 0x04003EF2 RID: 16114
		[OriginalName("RET_RAID_AVATAR_NOT_EXIST")]
		RetRaidAvatarNotExist,
		// Token: 0x04003EF3 RID: 16115
		[OriginalName("RET_CHALLENGE_RAID_REWARD_ALREADY")]
		RetChallengeRaidRewardAlready,
		// Token: 0x04003EF4 RID: 16116
		[OriginalName("RET_CHALLENGE_RAID_SCORE_NOT_REACH")]
		RetChallengeRaidScoreNotReach,
		// Token: 0x04003EF5 RID: 16117
		[OriginalName("RET_CHALLENGE_RAID_NOT_OPEN")]
		RetChallengeRaidNotOpen,
		// Token: 0x04003EF6 RID: 16118
		[OriginalName("RET_RAID_FINISHED")]
		RetRaidFinished,
		// Token: 0x04003EF7 RID: 16119
		[OriginalName("RET_RAID_WORLD_LEVEL_NOT_LOCK")]
		RetRaidWorldLevelNotLock,
		// Token: 0x04003EF8 RID: 16120
		[OriginalName("RET_RAID_CANNOT_USE_ASSIST")]
		RetRaidCannotUseAssist,
		// Token: 0x04003EF9 RID: 16121
		[OriginalName("RET_RAID_AVATAR_NOT_MATCH")]
		RetRaidAvatarNotMatch,
		// Token: 0x04003EFA RID: 16122
		[OriginalName("RET_RAID_CAN_NOT_SAVE")]
		RetRaidCanNotSave,
		// Token: 0x04003EFB RID: 16123
		[OriginalName("RET_RAID_NO_SAVE")]
		RetRaidNoSave,
		// Token: 0x04003EFC RID: 16124
		[OriginalName("RET_ACTIVITY_RAID_NOT_OPEN")]
		RetActivityRaidNotOpen,
		// Token: 0x04003EFD RID: 16125
		[OriginalName("RET_RAID_AVATAR_CAPTAIN_NOT_EXIST")]
		RetRaidAvatarCaptainNotExist,
		// Token: 0x04003EFE RID: 16126
		[OriginalName("RET_RAID_STORY_LINE_NOT_MATCH")]
		RetRaidStoryLineNotMatch,
		// Token: 0x04003EFF RID: 16127
		[OriginalName("RET_TALK_EVENT_ALREADY_TAKEN")]
		RetTalkEventAlreadyTaken = 3151,
		// Token: 0x04003F00 RID: 16128
		[OriginalName("RET_NPC_ALREADY_MEET")]
		RetNpcAlreadyMeet,
		// Token: 0x04003F01 RID: 16129
		[OriginalName("RET_NPC_NOT_IN_CONFIG")]
		RetNpcNotInConfig,
		// Token: 0x04003F02 RID: 16130
		[OriginalName("RET_DIALOGUE_GROUP_DISMATCH")]
		RetDialogueGroupDismatch,
		// Token: 0x04003F03 RID: 16131
		[OriginalName("RET_DIALOGUE_EVENT_INVALID")]
		RetDialogueEventInvalid,
		// Token: 0x04003F04 RID: 16132
		[OriginalName("RET_TALK_EVENT_TAKE_PROTO_NOT_MATCH")]
		RetTalkEventTakeProtoNotMatch,
		// Token: 0x04003F05 RID: 16133
		[OriginalName("RET_TALK_EVENT_NOT_VALID")]
		RetTalkEventNotValid,
		// Token: 0x04003F06 RID: 16134
		[OriginalName("RET_EXPEDITION_CONFIG_NOT_EXIST")]
		RetExpeditionConfigNotExist = 3201,
		// Token: 0x04003F07 RID: 16135
		[OriginalName("RET_EXPEDITION_REWARD_CONFIG_NOT_EXIST")]
		RetExpeditionRewardConfigNotExist,
		// Token: 0x04003F08 RID: 16136
		[OriginalName("RET_EXPEDITION_NOT_UNLOCKED")]
		RetExpeditionNotUnlocked,
		// Token: 0x04003F09 RID: 16137
		[OriginalName("RET_EXPEDITION_ALREADY_ACCEPTED")]
		RetExpeditionAlreadyAccepted,
		// Token: 0x04003F0A RID: 16138
		[OriginalName("RET_EXPEDITION_REPEATED_AVATAR")]
		RetExpeditionRepeatedAvatar,
		// Token: 0x04003F0B RID: 16139
		[OriginalName("RET_AVATAR_ALREADY_DISPATCHED")]
		RetAvatarAlreadyDispatched,
		// Token: 0x04003F0C RID: 16140
		[OriginalName("RET_EXPEDITION_NOT_ACCEPTED")]
		RetExpeditionNotAccepted,
		// Token: 0x04003F0D RID: 16141
		[OriginalName("RET_EXPEDITION_NOT_FINISH")]
		RetExpeditionNotFinish,
		// Token: 0x04003F0E RID: 16142
		[OriginalName("RET_EXPEDITION_ALREADY_FINISH")]
		RetExpeditionAlreadyFinish,
		// Token: 0x04003F0F RID: 16143
		[OriginalName("RET_EXPEDITION_TEAM_COUNT_LIMIT")]
		RetExpeditionTeamCountLimit,
		// Token: 0x04003F10 RID: 16144
		[OriginalName("RET_EXPEDITION_AVATAR_NUM_NOT_MATCH")]
		RetExpeditionAvatarNumNotMatch,
		// Token: 0x04003F11 RID: 16145
		[OriginalName("RET_EXPEDITION_NOT_OPEN")]
		RetExpeditionNotOpen,
		// Token: 0x04003F12 RID: 16146
		[OriginalName("RET_EXPEDITION_FRIEND_AVATAR_NOT_VALID")]
		RetExpeditionFriendAvatarNotValid,
		// Token: 0x04003F13 RID: 16147
		[OriginalName("RET_EXPEDITION_NOT_PUBLISHED")]
		RetExpeditionNotPublished,
		// Token: 0x04003F14 RID: 16148
		[OriginalName("RET_LOGIN_ACTIVITY_HAS_TAKEN")]
		RetLoginActivityHasTaken = 3301,
		// Token: 0x04003F15 RID: 16149
		[OriginalName("RET_LOGIN_ACTIVITY_DAYS_LACK")]
		RetLoginActivityDaysLack,
		// Token: 0x04003F16 RID: 16150
		[OriginalName("RET_TRIAL_ACTIVITY_REWARD_ALREADY_TAKE")]
		RetTrialActivityRewardAlreadyTake,
		// Token: 0x04003F17 RID: 16151
		[OriginalName("RET_TRIAL_ACTIVITY_STAGE_NOT_FINISH")]
		RetTrialActivityStageNotFinish,
		// Token: 0x04003F18 RID: 16152
		[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_HAS_TAKEN")]
		RetMaterialSubmitActivityHasTaken,
		// Token: 0x04003F19 RID: 16153
		[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_MATERIAL_NOT_SUBMITTED")]
		RetMaterialSubmitActivityMaterialNotSubmitted,
		// Token: 0x04003F1A RID: 16154
		[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_MATERIAL_ALREADY_SUBMITTED")]
		RetMaterialSubmitActivityMaterialAlreadySubmitted,
		// Token: 0x04003F1B RID: 16155
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_STORY_ERROR")]
		RetFantasticStoryActivityStoryError,
		// Token: 0x04003F1C RID: 16156
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_STORY_NOT_OPEN")]
		RetFantasticStoryActivityStoryNotOpen,
		// Token: 0x04003F1D RID: 16157
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_ERROR")]
		RetFantasticStoryActivityBattleError,
		// Token: 0x04003F1E RID: 16158
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_NOT_OPEN")]
		RetFantasticStoryActivityBattleNotOpen,
		// Token: 0x04003F1F RID: 16159
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_AVATAR_ERROR")]
		RetFantasticStoryActivityBattleAvatarError,
		// Token: 0x04003F20 RID: 16160
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_BUFF_ERROR")]
		RetFantasticStoryActivityBattleBuffError,
		// Token: 0x04003F21 RID: 16161
		[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_PRE_BATTLE_SCORE_NOT_ENOUGH")]
		RetFantasticStoryActivityPreBattleScoreNotEnough,
		// Token: 0x04003F22 RID: 16162
		[OriginalName("RET_TRIAL_ACTIVITY_ALREADY_IN_TRIAL_ACTIVITY")]
		RetTrialActivityAlreadyInTrialActivity,
		// Token: 0x04003F23 RID: 16163
		[OriginalName("RET_COMMON_ACTIVITY_NOT_OPEN")]
		RetCommonActivityNotOpen,
		// Token: 0x04003F24 RID: 16164
		[OriginalName("RET_MESSAGE_CONFIG_NOT_EXIST")]
		RetMessageConfigNotExist = 3501,
		// Token: 0x04003F25 RID: 16165
		[OriginalName("RET_MESSAGE_SECTION_NOT_TAKE")]
		RetMessageSectionNotTake,
		// Token: 0x04003F26 RID: 16166
		[OriginalName("RET_MESSAGE_GROUP_NOT_TAKE")]
		RetMessageGroupNotTake,
		// Token: 0x04003F27 RID: 16167
		[OriginalName("RET_MESSAGE_SECTION_ID_NOT_MATCH")]
		RetMessageSectionIdNotMatch,
		// Token: 0x04003F28 RID: 16168
		[OriginalName("RET_MESSAGE_SECTION_CAN_NOT_FINISH")]
		RetMessageSectionCanNotFinish,
		// Token: 0x04003F29 RID: 16169
		[OriginalName("RET_MESSAGE_ITEM_CAN_NOT_FINISH")]
		RetMessageItemCanNotFinish,
		// Token: 0x04003F2A RID: 16170
		[OriginalName("RET_MESSAGE_ITEM_RAID_CAN_NOT_FINISH")]
		RetMessageItemRaidCanNotFinish,
		// Token: 0x04003F2B RID: 16171
		[OriginalName("RET_FRIEND_ALREADY_IS_FRIEND")]
		RetFriendAlreadyIsFriend = 3601,
		// Token: 0x04003F2C RID: 16172
		[OriginalName("RET_FRIEND_IS_NOT_FRIEND")]
		RetFriendIsNotFriend,
		// Token: 0x04003F2D RID: 16173
		[OriginalName("RET_FRIEND_APPLY_EXPIRE")]
		RetFriendApplyExpire,
		// Token: 0x04003F2E RID: 16174
		[OriginalName("RET_FRIEND_IN_BLACKLIST")]
		RetFriendInBlacklist,
		// Token: 0x04003F2F RID: 16175
		[OriginalName("RET_FRIEND_NOT_IN_BLACKLIST")]
		RetFriendNotInBlacklist,
		// Token: 0x04003F30 RID: 16176
		[OriginalName("RET_FRIEND_NUMBER_LIMIT")]
		RetFriendNumberLimit,
		// Token: 0x04003F31 RID: 16177
		[OriginalName("RET_FRIEND_BLACKLIST_NUMBER_LIMIT")]
		RetFriendBlacklistNumberLimit,
		// Token: 0x04003F32 RID: 16178
		[OriginalName("RET_FRIEND_DAILY_APPLY_LIMIT")]
		RetFriendDailyApplyLimit,
		// Token: 0x04003F33 RID: 16179
		[OriginalName("RET_FRIEND_IN_HANDLE_LIMIT")]
		RetFriendInHandleLimit,
		// Token: 0x04003F34 RID: 16180
		[OriginalName("RET_FRIEND_APPLY_IN_CD")]
		RetFriendApplyInCd,
		// Token: 0x04003F35 RID: 16181
		[OriginalName("RET_FRIEND_REMARK_NAME_FORMAT_ERROR")]
		RetFriendRemarkNameFormatError,
		// Token: 0x04003F36 RID: 16182
		[OriginalName("RET_FRIEND_PLAYER_NOT_FOUND")]
		RetFriendPlayerNotFound,
		// Token: 0x04003F37 RID: 16183
		[OriginalName("RET_FRIEND_IN_TARGET_BLACKLIST")]
		RetFriendInTargetBlacklist,
		// Token: 0x04003F38 RID: 16184
		[OriginalName("RET_FRIEND_TARGET_NUMBER_LIMIT")]
		RetFriendTargetNumberLimit,
		// Token: 0x04003F39 RID: 16185
		[OriginalName("RET_ASSIST_QUERY_TOO_FAST")]
		RetAssistQueryTooFast,
		// Token: 0x04003F3A RID: 16186
		[OriginalName("RET_ASSIST_NOT_EXIST")]
		RetAssistNotExist,
		// Token: 0x04003F3B RID: 16187
		[OriginalName("RET_ASSIST_USED_ALREADY")]
		RetAssistUsedAlready,
		// Token: 0x04003F3C RID: 16188
		[OriginalName("RET_FRIEND_REPORT_REASON_FORMAT_ERROR")]
		RetFriendReportReasonFormatError,
		// Token: 0x04003F3D RID: 16189
		[OriginalName("RET_FRIEND_REPORT_SENSITIVE_WORDS")]
		RetFriendReportSensitiveWords,
		// Token: 0x04003F3E RID: 16190
		[OriginalName("RET_ASSIST_USED_TIMES_OVER")]
		RetAssistUsedTimesOver,
		// Token: 0x04003F3F RID: 16191
		[OriginalName("RET_ASSIST_QUIT_ALREADY")]
		RetAssistQuitAlready,
		// Token: 0x04003F40 RID: 16192
		[OriginalName("RET_ASSIST_AVATAR_IN_LINEUP")]
		RetAssistAvatarInLineup,
		// Token: 0x04003F41 RID: 16193
		[OriginalName("RET_ASSIST_NO_REWARD")]
		RetAssistNoReward,
		// Token: 0x04003F42 RID: 16194
		[OriginalName("RET_FRIEND_SEARCH_NUM_LIMIT")]
		RetFriendSearchNumLimit,
		// Token: 0x04003F43 RID: 16195
		[OriginalName("RET_FRIEND_SEARCH_IN_CD")]
		RetFriendSearchInCd,
		// Token: 0x04003F44 RID: 16196
		[OriginalName("RET_FRIEND_REMARK_NAME_UTF8_ERROR")]
		RetFriendRemarkNameUtf8Error,
		// Token: 0x04003F45 RID: 16197
		[OriginalName("RET_FRIEND_REPORT_REASON_UTF8_ERROR")]
		RetFriendReportReasonUtf8Error,
		// Token: 0x04003F46 RID: 16198
		[OriginalName("RET_ASSIST_SET_ALREADY")]
		RetAssistSetAlready,
		// Token: 0x04003F47 RID: 16199
		[OriginalName("RET_FRIEND_TARGET_FORBID_OTHER_APPLY")]
		RetFriendTargetForbidOtherApply,
		// Token: 0x04003F48 RID: 16200
		[OriginalName("RET_FRIEND_MARKED_CNT_MAX")]
		RetFriendMarkedCntMax,
		// Token: 0x04003F49 RID: 16201
		[OriginalName("RET_FRIEND_MARKED_ALREADY")]
		RetFriendMarkedAlready,
		// Token: 0x04003F4A RID: 16202
		[OriginalName("RET_FRIEND_NOT_MARKED")]
		RetFriendNotMarked,
		// Token: 0x04003F4B RID: 16203
		[OriginalName("RET_FRIEND_CHALLENGE_LINEUP_RECOMMEND_IN_CD")]
		RetFriendChallengeLineupRecommendInCd,
		// Token: 0x04003F4C RID: 16204
		[OriginalName("RET_VIEW_PLAYER_CARD_IN_CD")]
		RetViewPlayerCardInCd,
		// Token: 0x04003F4D RID: 16205
		[OriginalName("RET_VIEW_PLAYER_BATTLE_RECORD_IN_CD")]
		RetViewPlayerBattleRecordInCd,
		// Token: 0x04003F4E RID: 16206
		[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_NOT_EXIST")]
		RetPlayerBoardHeadIconNotExist = 3701,
		// Token: 0x04003F4F RID: 16207
		[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_LOCKED")]
		RetPlayerBoardHeadIconLocked,
		// Token: 0x04003F50 RID: 16208
		[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_ALREADY_UNLOCKED")]
		RetPlayerBoardHeadIconAlreadyUnlocked,
		// Token: 0x04003F51 RID: 16209
		[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_NOT_EXIST")]
		RetPlayerBoardDisplayAvatarNotExist,
		// Token: 0x04003F52 RID: 16210
		[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_EXCEED_LIMIT")]
		RetPlayerBoardDisplayAvatarExceedLimit,
		// Token: 0x04003F53 RID: 16211
		[OriginalName("RET_PLAYER_BOARD_DISPLAY_REPEATED_AVATAR")]
		RetPlayerBoardDisplayRepeatedAvatar,
		// Token: 0x04003F54 RID: 16212
		[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_SAME_POS")]
		RetPlayerBoardDisplayAvatarSamePos,
		// Token: 0x04003F55 RID: 16213
		[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_LOCKED")]
		RetPlayerBoardDisplayAvatarLocked,
		// Token: 0x04003F56 RID: 16214
		[OriginalName("RET_SIGNATURE_LENGTH_EXCEED_LIMIT")]
		RetSignatureLengthExceedLimit,
		// Token: 0x04003F57 RID: 16215
		[OriginalName("RET_SIGNATURE_SENSITIVE_WORDS")]
		RetSignatureSensitiveWords,
		// Token: 0x04003F58 RID: 16216
		[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_NOT_EXIST")]
		RetPlayerBoardAssistAvatarNotExist = 3712,
		// Token: 0x04003F59 RID: 16217
		[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_LOCKED")]
		RetPlayerBoardAssistAvatarLocked,
		// Token: 0x04003F5A RID: 16218
		[OriginalName("RET_SIGNATURE_UTF8_ERROR")]
		RetSignatureUtf8Error,
		// Token: 0x04003F5B RID: 16219
		[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_CNT_ERROR")]
		RetPlayerBoardAssistAvatarCntError,
		// Token: 0x04003F5C RID: 16220
		[OriginalName("RET_BATTLE_PASS_TIER_NOT_VALID")]
		RetBattlePassTierNotValid = 3801,
		// Token: 0x04003F5D RID: 16221
		[OriginalName("RET_BATTLE_PASS_LEVEL_NOT_MEET")]
		RetBattlePassLevelNotMeet,
		// Token: 0x04003F5E RID: 16222
		[OriginalName("RET_BATTLE_PASS_REWARD_TAKE_ALREADY")]
		RetBattlePassRewardTakeAlready,
		// Token: 0x04003F5F RID: 16223
		[OriginalName("RET_BATTLE_PASS_NOT_PREMIUM")]
		RetBattlePassNotPremium,
		// Token: 0x04003F60 RID: 16224
		[OriginalName("RET_BATTLE_PASS_NOT_DOING")]
		RetBattlePassNotDoing,
		// Token: 0x04003F61 RID: 16225
		[OriginalName("RET_BATTLE_PASS_LEVEL_INVALID")]
		RetBattlePassLevelInvalid,
		// Token: 0x04003F62 RID: 16226
		[OriginalName("RET_BATTLE_PASS_NOT_UNLOCK")]
		RetBattlePassNotUnlock,
		// Token: 0x04003F63 RID: 16227
		[OriginalName("RET_BATTLE_PASS_NO_REWARD")]
		RetBattlePassNoReward,
		// Token: 0x04003F64 RID: 16228
		[OriginalName("RET_BATTLE_PASS_QUEST_NOT_VALID")]
		RetBattlePassQuestNotValid,
		// Token: 0x04003F65 RID: 16229
		[OriginalName("RET_BATTLE_PASS_NOT_CHOOSE_OPTIONAL")]
		RetBattlePassNotChooseOptional,
		// Token: 0x04003F66 RID: 16230
		[OriginalName("RET_BATTLE_PASS_NOT_TAKE_REWARD")]
		RetBattlePassNotTakeReward,
		// Token: 0x04003F67 RID: 16231
		[OriginalName("RET_BATTLE_PASS_OPTIONAL_NOT_VALID")]
		RetBattlePassOptionalNotValid,
		// Token: 0x04003F68 RID: 16232
		[OriginalName("RET_BATTLE_PASS_BUY_ALREADY")]
		RetBattlePassBuyAlready,
		// Token: 0x04003F69 RID: 16233
		[OriginalName("RET_BATTLE_PASS_NEAR_END")]
		RetBattlePassNearEnd,
		// Token: 0x04003F6A RID: 16234
		[OriginalName("RET_MUSIC_LOCKED")]
		RetMusicLocked = 3901,
		// Token: 0x04003F6B RID: 16235
		[OriginalName("RET_MUSIC_NOT_EXIST")]
		RetMusicNotExist,
		// Token: 0x04003F6C RID: 16236
		[OriginalName("RET_MUSIC_UNLOCK_FAILED")]
		RetMusicUnlockFailed,
		// Token: 0x04003F6D RID: 16237
		[OriginalName("RET_PUNK_LORD_LACK_SUMMON_TIMES")]
		RetPunkLordLackSummonTimes = 4001,
		// Token: 0x04003F6E RID: 16238
		[OriginalName("RET_PUNK_LORD_ATTACKING_MONSTER_LIMIT")]
		RetPunkLordAttackingMonsterLimit,
		// Token: 0x04003F6F RID: 16239
		[OriginalName("RET_PUNK_LORD_MONSTER_NOT_EXIST")]
		RetPunkLordMonsterNotExist,
		// Token: 0x04003F70 RID: 16240
		[OriginalName("RET_PUNK_LORD_MONSTER_ALREADY_SHARED")]
		RetPunkLordMonsterAlreadyShared,
		// Token: 0x04003F71 RID: 16241
		[OriginalName("RET_PUNK_LORD_MONSTER_EXPIRED")]
		RetPunkLordMonsterExpired,
		// Token: 0x04003F72 RID: 16242
		[OriginalName("RET_PUNK_LORD_SELF_MONSTER_ATTACK_LIMIT")]
		RetPunkLordSelfMonsterAttackLimit,
		// Token: 0x04003F73 RID: 16243
		[OriginalName("RET_PUNK_LORD_LACK_SUPPORT_TIMES")]
		RetPunkLordLackSupportTimes,
		// Token: 0x04003F74 RID: 16244
		[OriginalName("RET_PUNK_LORD_MONSTER_ALREADY_KILLED")]
		RetPunkLordMonsterAlreadyKilled,
		// Token: 0x04003F75 RID: 16245
		[OriginalName("RET_PUNK_LORD_MONSTER_ATTACKER_LIMIT")]
		RetPunkLordMonsterAttackerLimit,
		// Token: 0x04003F76 RID: 16246
		[OriginalName("RET_PUNK_LORD_WORLD_LEVLE_NOT_VALID")]
		RetPunkLordWorldLevleNotValid,
		// Token: 0x04003F77 RID: 16247
		[OriginalName("RET_PUNK_LORD_REWARD_LEVLE_NOT_EXIST")]
		RetPunkLordRewardLevleNotExist,
		// Token: 0x04003F78 RID: 16248
		[OriginalName("RET_PUNK_LORD_POINT_NOT_MEET")]
		RetPunkLordPointNotMeet,
		// Token: 0x04003F79 RID: 16249
		[OriginalName("RET_PUNK_LORD_IN_ATTACKING")]
		RetPunkLordInAttacking,
		// Token: 0x04003F7A RID: 16250
		[OriginalName("RET_PUNK_LORD_OPERATION_IN_CD")]
		RetPunkLordOperationInCd,
		// Token: 0x04003F7B RID: 16251
		[OriginalName("RET_PUNK_LORD_REWARD_ALREADY_TAKEN")]
		RetPunkLordRewardAlreadyTaken,
		// Token: 0x04003F7C RID: 16252
		[OriginalName("RET_PUNK_LORD_OVER_BONUS_REWARD_LIMIT")]
		RetPunkLordOverBonusRewardLimit,
		// Token: 0x04003F7D RID: 16253
		[OriginalName("RET_PUNK_LORD_NOT_IN_SCHEDULE")]
		RetPunkLordNotInSchedule,
		// Token: 0x04003F7E RID: 16254
		[OriginalName("RET_PUNK_LORD_MONSTER_NOT_ATTACKED")]
		RetPunkLordMonsterNotAttacked,
		// Token: 0x04003F7F RID: 16255
		[OriginalName("RET_PUNK_LORD_MONSTER_NOT_KILLED")]
		RetPunkLordMonsterNotKilled,
		// Token: 0x04003F80 RID: 16256
		[OriginalName("RET_PUNK_LORD_MONSTER_KILLED_SCORE_ALREADY_TAKE")]
		RetPunkLordMonsterKilledScoreAlreadyTake,
		// Token: 0x04003F81 RID: 16257
		[OriginalName("RET_PUNK_LORD_REWARD_LEVLE_ALREADY_TAKE")]
		RetPunkLordRewardLevleAlreadyTake,
		// Token: 0x04003F82 RID: 16258
		[OriginalName("RET_DAILY_ACTIVE_LEVEL_INVALID")]
		RetDailyActiveLevelInvalid = 4101,
		// Token: 0x04003F83 RID: 16259
		[OriginalName("RET_DAILY_ACTIVE_LEVEL_REWARD_ALREADY_TAKEN")]
		RetDailyActiveLevelRewardAlreadyTaken,
		// Token: 0x04003F84 RID: 16260
		[OriginalName("RET_DAILY_ACTIVE_LEVEL_AP_NOT_ENOUGH")]
		RetDailyActiveLevelApNotEnough,
		// Token: 0x04003F85 RID: 16261
		[OriginalName("RET_DAILY_MEET_PAM")]
		RetDailyMeetPam = 4201,
		// Token: 0x04003F86 RID: 16262
		[OriginalName("RET_REPLAY_ID_NOT_MATCH")]
		RetReplayIdNotMatch = 4251,
		// Token: 0x04003F87 RID: 16263
		[OriginalName("RET_REPLAY_REQ_NOT_VALID")]
		RetReplayReqNotValid,
		// Token: 0x04003F88 RID: 16264
		[OriginalName("RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_NOT_PASSED")]
		RetFightActivityDifficultyLevelNotPassed = 4301,
		// Token: 0x04003F89 RID: 16265
		[OriginalName("RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_REWARD_ALREADY_TAKE")]
		RetFightActivityDifficultyLevelRewardAlreadyTake,
		// Token: 0x04003F8A RID: 16266
		[OriginalName("RET_FIGHT_ACTIVITY_STAGE_NOT_OPEN")]
		RetFightActivityStageNotOpen,
		// Token: 0x04003F8B RID: 16267
		[OriginalName("RET_FIGHT_ACTIVITY_LEVEL_NOT_UNLOCK")]
		RetFightActivityLevelNotUnlock,
		// Token: 0x04003F8C RID: 16268
		[OriginalName("RET_TRAIN_VISITOR_VISITOR_NOT_EXIST")]
		RetTrainVisitorVisitorNotExist = 4351,
		// Token: 0x04003F8D RID: 16269
		[OriginalName("RET_TRAIN_VISITOR_BEHAVIOR_NOT_EXIST")]
		RetTrainVisitorBehaviorNotExist,
		// Token: 0x04003F8E RID: 16270
		[OriginalName("RET_TRAIN_VISITOR_BEHAVIOR_FINISHED")]
		RetTrainVisitorBehaviorFinished,
		// Token: 0x04003F8F RID: 16271
		[OriginalName("RET_TRAIN_VISITOR_ALL_BEHAVIOR_REWARD_TAKEN")]
		RetTrainVisitorAllBehaviorRewardTaken,
		// Token: 0x04003F90 RID: 16272
		[OriginalName("RET_TRAIN_VISITOR_GET_ON_MISSION_NOT_FINISH")]
		RetTrainVisitorGetOnMissionNotFinish,
		// Token: 0x04003F91 RID: 16273
		[OriginalName("RET_TRAIN_VISITOR_NOT_GET_OFF")]
		RetTrainVisitorNotGetOff,
		// Token: 0x04003F92 RID: 16274
		[OriginalName("RET_TEXT_JOIN_UNKNOW_IS_OVERRIDE")]
		RetTextJoinUnknowIsOverride = 4401,
		// Token: 0x04003F93 RID: 16275
		[OriginalName("RET_TEXT_JOIN_ID_NOT_EXIST")]
		RetTextJoinIdNotExist,
		// Token: 0x04003F94 RID: 16276
		[OriginalName("RET_TEXT_JOIN_CAN_NOT_OVERRIDE")]
		RetTextJoinCanNotOverride,
		// Token: 0x04003F95 RID: 16277
		[OriginalName("RET_TEXT_JOIN_ITEM_ID_ERROR")]
		RetTextJoinItemIdError,
		// Token: 0x04003F96 RID: 16278
		[OriginalName("RET_TEXT_JOIN_SENSITIVE_CHECK_ERROR")]
		RetTextJoinSensitiveCheckError,
		// Token: 0x04003F97 RID: 16279
		[OriginalName("RET_TEXT_JOIN_MUST_OVERRIDE")]
		RetTextJoinMustOverride,
		// Token: 0x04003F98 RID: 16280
		[OriginalName("RET_TEXT_JOIN_TEXT_EMPTY")]
		RetTextJoinTextEmpty,
		// Token: 0x04003F99 RID: 16281
		[OriginalName("RET_TEXT_JOIN_TEXT_FORMAT_ERROR")]
		RetTextJoinTextFormatError,
		// Token: 0x04003F9A RID: 16282
		[OriginalName("RET_TEXT_JOIN_TEXT_UTF8_ERROR")]
		RetTextJoinTextUtf8Error,
		// Token: 0x04003F9B RID: 16283
		[OriginalName("RET_TEXT_JOIN_BATCH_REQ_ID_REPEAT")]
		RetTextJoinBatchReqIdRepeat,
		// Token: 0x04003F9C RID: 16284
		[OriginalName("RET_TEXT_JOIN_TYPE_NOT_SUPPORT_BATCH_REQ")]
		RetTextJoinTypeNotSupportBatchReq,
		// Token: 0x04003F9D RID: 16285
		[OriginalName("RET_TEXT_JOIN_AVATAR_ID_NOT_EXIST")]
		RetTextJoinAvatarIdNotExist,
		// Token: 0x04003F9E RID: 16286
		[OriginalName("RET_TEXT_JOIN_UNKNOW_TYPE")]
		RetTextJoinUnknowType,
		// Token: 0x04003F9F RID: 16287
		[OriginalName("RET_PAM_MISSION_MISSION_ID_ERROR")]
		RetPamMissionMissionIdError = 4451,
		// Token: 0x04003FA0 RID: 16288
		[OriginalName("RET_PAM_MISSION_MISSION_EXPIRE")]
		RetPamMissionMissionExpire,
		// Token: 0x04003FA1 RID: 16289
		[OriginalName("RET_CHAT_TYPE_NOT_EXIST")]
		RetChatTypeNotExist = 4501,
		// Token: 0x04003FA2 RID: 16290
		[OriginalName("RET_MSG_TYPE_NOT_EXIST")]
		RetMsgTypeNotExist,
		// Token: 0x04003FA3 RID: 16291
		[OriginalName("RET_CHAT_NO_TARGET_UID")]
		RetChatNoTargetUid,
		// Token: 0x04003FA4 RID: 16292
		[OriginalName("RET_CHAT_MSG_EMPTY")]
		RetChatMsgEmpty,
		// Token: 0x04003FA5 RID: 16293
		[OriginalName("RET_CHAT_MSG_EXCEED_LIMIT")]
		RetChatMsgExceedLimit,
		// Token: 0x04003FA6 RID: 16294
		[OriginalName("RET_CHAT_MSG_SENSITIVE_CHECK_ERROR")]
		RetChatMsgSensitiveCheckError,
		// Token: 0x04003FA7 RID: 16295
		[OriginalName("RET_CHAT_MSG_UTF8_ERROR")]
		RetChatMsgUtf8Error,
		// Token: 0x04003FA8 RID: 16296
		[OriginalName("RET_CHAT_FORBID_SWITCH_OPEN")]
		RetChatForbidSwitchOpen,
		// Token: 0x04003FA9 RID: 16297
		[OriginalName("RET_CHAT_FORBID")]
		RetChatForbid,
		// Token: 0x04003FAA RID: 16298
		[OriginalName("RET_CHAT_MSG_INCLUDE_SPECIAL_STR")]
		RetChatMsgIncludeSpecialStr,
		// Token: 0x04003FAB RID: 16299
		[OriginalName("RET_CHAT_MSG_EMOJI_NOT_EXIST")]
		RetChatMsgEmojiNotExist,
		// Token: 0x04003FAC RID: 16300
		[OriginalName("RET_CHAT_MSG_EMOJI_GENDER_NOT_MATCH")]
		RetChatMsgEmojiGenderNotMatch,
		// Token: 0x04003FAD RID: 16301
		[OriginalName("RET_CHAT_MSG_EMOJI_NOT_MARKED")]
		RetChatMsgEmojiNotMarked,
		// Token: 0x04003FAE RID: 16302
		[OriginalName("RET_CHAT_MSG_EMOJI_ALREADY_MARKED")]
		RetChatMsgEmojiAlreadyMarked,
		// Token: 0x04003FAF RID: 16303
		[OriginalName("RET_CHAT_MSG_EMOJI_MARKED_MAX_LIMIT")]
		RetChatMsgEmojiMarkedMaxLimit,
		// Token: 0x04003FB0 RID: 16304
		[OriginalName("RET_BOXING_CLUB_CHALLENGE_NOT_OPEN")]
		RetBoxingClubChallengeNotOpen = 4601,
		// Token: 0x04003FB1 RID: 16305
		[OriginalName("RET_MUSEUM_NOT_OPEN")]
		RetMuseumNotOpen = 4651,
		// Token: 0x04003FB2 RID: 16306
		[OriginalName("RET_MUSEUM_TURN_CNT_NOT_MATCH")]
		RetMuseumTurnCntNotMatch,
		// Token: 0x04003FB3 RID: 16307
		[OriginalName("RET_MUSEUM_PHASE_NOT_REACH")]
		RetMuseumPhaseNotReach,
		// Token: 0x04003FB4 RID: 16308
		[OriginalName("RET_MUSEUM_UNKNOW_STUFF")]
		RetMuseumUnknowStuff,
		// Token: 0x04003FB5 RID: 16309
		[OriginalName("RET_MUSEUM_UNKNOW_AREA")]
		RetMuseumUnknowArea,
		// Token: 0x04003FB6 RID: 16310
		[OriginalName("RET_MUSEUM_UNKNOW_POS")]
		RetMuseumUnknowPos,
		// Token: 0x04003FB7 RID: 16311
		[OriginalName("RET_MUSEUM_STUFF_ALREADY_IN_AREA")]
		RetMuseumStuffAlreadyInArea,
		// Token: 0x04003FB8 RID: 16312
		[OriginalName("RET_MUSEUM_STUFF_NOT_IN_AREA")]
		RetMuseumStuffNotInArea,
		// Token: 0x04003FB9 RID: 16313
		[OriginalName("RET_MUSEUM_GET_NPC_REPEAT")]
		RetMuseumGetNpcRepeat,
		// Token: 0x04003FBA RID: 16314
		[OriginalName("RET_MUSEUM_GET_NPC_UNLOCK")]
		RetMuseumGetNpcUnlock,
		// Token: 0x04003FBB RID: 16315
		[OriginalName("RET_MUSEUM_GET_NPC_NOT_ENOUGH")]
		RetMuseumGetNpcNotEnough,
		// Token: 0x04003FBC RID: 16316
		[OriginalName("RET_MUSEUM_CHANGE_STUFF_AREA_ERROR")]
		RetMuseumChangeStuffAreaError,
		// Token: 0x04003FBD RID: 16317
		[OriginalName("RET_MUSEUM_NOT_INIT")]
		RetMuseumNotInit,
		// Token: 0x04003FBE RID: 16318
		[OriginalName("RET_MUSEUM_EVENT_ERROR")]
		RetMuseumEventError,
		// Token: 0x04003FBF RID: 16319
		[OriginalName("RET_MUSEUM_UNKNOW_CHOOSE_EVENT_ID")]
		RetMuseumUnknowChooseEventId,
		// Token: 0x04003FC0 RID: 16320
		[OriginalName("RET_MUSEUM_EVENT_ORDER_NOT_MATCH")]
		RetMuseumEventOrderNotMatch,
		// Token: 0x04003FC1 RID: 16321
		[OriginalName("RET_MUSEUM_EVENT_PHASE_NOT_UNLOCK")]
		RetMuseumEventPhaseNotUnlock,
		// Token: 0x04003FC2 RID: 16322
		[OriginalName("RET_MUSEUM_EVENT_MISSION_NOT_FOUND")]
		RetMuseumEventMissionNotFound,
		// Token: 0x04003FC3 RID: 16323
		[OriginalName("RET_MUSEUM_AREA_LEVEL_UP_ALREADY")]
		RetMuseumAreaLevelUpAlready,
		// Token: 0x04003FC4 RID: 16324
		[OriginalName("RET_MUSEUM_STUFF_ALREADY_USED")]
		RetMuseumStuffAlreadyUsed,
		// Token: 0x04003FC5 RID: 16325
		[OriginalName("RET_MUSEUM_EVENT_ROUND_NOT_UNLOCK")]
		RetMuseumEventRoundNotUnlock,
		// Token: 0x04003FC6 RID: 16326
		[OriginalName("RET_MUSEUM_STUFF_IN_AREA")]
		RetMuseumStuffInArea,
		// Token: 0x04003FC7 RID: 16327
		[OriginalName("RET_MUSEUM_STUFF_DISPATCH")]
		RetMuseumStuffDispatch,
		// Token: 0x04003FC8 RID: 16328
		[OriginalName("RET_MUSEUM_IS_END")]
		RetMuseumIsEnd,
		// Token: 0x04003FC9 RID: 16329
		[OriginalName("RET_MUSEUM_STUFF_LEAVING")]
		RetMuseumStuffLeaving,
		// Token: 0x04003FCA RID: 16330
		[OriginalName("RET_MUSEUM_EVENT_MISSION_NOT_FINISH")]
		RetMuseumEventMissionNotFinish = 4678,
		// Token: 0x04003FCB RID: 16331
		[OriginalName("RET_MUSEUM_COLLECT_REWARD_NOT_EXIST")]
		RetMuseumCollectRewardNotExist,
		// Token: 0x04003FCC RID: 16332
		[OriginalName("RET_MUSEUM_COLLECT_REWARD_ALREADY_TAKEN")]
		RetMuseumCollectRewardAlreadyTaken,
		// Token: 0x04003FCD RID: 16333
		[OriginalName("RET_MUSEUM_ACCEPT_MISSION_MAX_LIMIT")]
		RetMuseumAcceptMissionMaxLimit,
		// Token: 0x04003FCE RID: 16334
		[OriginalName("RET_ROGUE_CHALLENGE_NOT_OPEN")]
		RetRogueChallengeNotOpen = 4701,
		// Token: 0x04003FCF RID: 16335
		[OriginalName("RET_ROGUE_CHALLENGE_ASSIS_REFRESH_LIMIT")]
		RetRogueChallengeAssisRefreshLimit,
		// Token: 0x04003FD0 RID: 16336
		[OriginalName("RET_ALLEY_NOT_INIT")]
		RetAlleyNotInit = 4721,
		// Token: 0x04003FD1 RID: 16337
		[OriginalName("RET_ALLEY_NOT_OPEN")]
		RetAlleyNotOpen,
		// Token: 0x04003FD2 RID: 16338
		[OriginalName("RET_ALLEY_MAP_NOT_EXIST")]
		RetAlleyMapNotExist = 4724,
		// Token: 0x04003FD3 RID: 16339
		[OriginalName("RET_ALLEY_EMPTY_POS_LIST")]
		RetAlleyEmptyPosList,
		// Token: 0x04003FD4 RID: 16340
		[OriginalName("RET_ALLEY_LINE_POS_INVALID")]
		RetAlleyLinePosInvalid,
		// Token: 0x04003FD5 RID: 16341
		[OriginalName("RET_ALLEY_SHOP_NOT_UNLOCK")]
		RetAlleyShopNotUnlock,
		// Token: 0x04003FD6 RID: 16342
		[OriginalName("RET_ALLEY_DEPOT_FULL")]
		RetAlleyDepotFull,
		// Token: 0x04003FD7 RID: 16343
		[OriginalName("RET_ALLEY_SHOP_NOT_INCLUDE")]
		RetAlleyShopNotInclude,
		// Token: 0x04003FD8 RID: 16344
		[OriginalName("RET_ALLEY_EVENT_NOT_UNLOCK")]
		RetAlleyEventNotUnlock,
		// Token: 0x04003FD9 RID: 16345
		[OriginalName("RET_ALLEY_EVENT_NOT_REFRESH")]
		RetAlleyEventNotRefresh,
		// Token: 0x04003FDA RID: 16346
		[OriginalName("RET_ALLEY_EVENT_STATE_DOING")]
		RetAlleyEventStateDoing,
		// Token: 0x04003FDB RID: 16347
		[OriginalName("RET_ALLEY_EVENT_STATE_FINISH")]
		RetAlleyEventStateFinish,
		// Token: 0x04003FDC RID: 16348
		[OriginalName("RET_ALLEY_EVENT_ERROR")]
		RetAlleyEventError,
		// Token: 0x04003FDD RID: 16349
		[OriginalName("RET_ALLEY_REWARD_LEVEL_ERROR")]
		RetAlleyRewardLevelError,
		// Token: 0x04003FDE RID: 16350
		[OriginalName("RET_ALLEY_REWARD_PRESTIGE_NOT_ENOUGH")]
		RetAlleyRewardPrestigeNotEnough,
		// Token: 0x04003FDF RID: 16351
		[OriginalName("RET_ALLEY_SHIP_EMPTY")]
		RetAlleyShipEmpty,
		// Token: 0x04003FE0 RID: 16352
		[OriginalName("RET_ALLEY_SHIP_ID_DISMATCH")]
		RetAlleyShipIdDismatch,
		// Token: 0x04003FE1 RID: 16353
		[OriginalName("RET_ALLEY_SHIP_NOT_EXIST")]
		RetAlleyShipNotExist,
		// Token: 0x04003FE2 RID: 16354
		[OriginalName("RET_ALLEY_SHIP_NOT_UNLOCK")]
		RetAlleyShipNotUnlock,
		// Token: 0x04003FE3 RID: 16355
		[OriginalName("RET_ALLEY_GOODS_NOT_EXIST")]
		RetAlleyGoodsNotExist,
		// Token: 0x04003FE4 RID: 16356
		[OriginalName("RET_ALLEY_GOODS_NOT_UNLOCK")]
		RetAlleyGoodsNotUnlock,
		// Token: 0x04003FE5 RID: 16357
		[OriginalName("RET_ALLEY_PROFIT_NOT_POSITIVE")]
		RetAlleyProfitNotPositive,
		// Token: 0x04003FE6 RID: 16358
		[OriginalName("RET_ALLEY_SPECIAL_ORDER_DISMATCH")]
		RetAlleySpecialOrderDismatch,
		// Token: 0x04003FE7 RID: 16359
		[OriginalName("RET_ALLEY_ORDER_GOODS_OVER_LIMIT")]
		RetAlleyOrderGoodsOverLimit,
		// Token: 0x04003FE8 RID: 16360
		[OriginalName("RET_ALLEY_SPECIAL_ORDER_CONDITION_NOT_MEET")]
		RetAlleySpecialOrderConditionNotMeet,
		// Token: 0x04003FE9 RID: 16361
		[OriginalName("RET_ALLEY_DEPOT_SIZE_OVER_LIMIT")]
		RetAlleyDepotSizeOverLimit,
		// Token: 0x04003FEA RID: 16362
		[OriginalName("RET_ALLEY_GOODS_NOT_ENOUGH")]
		RetAlleyGoodsNotEnough,
		// Token: 0x04003FEB RID: 16363
		[OriginalName("RET_ALLEY_ORDER_INDEX_INVALID")]
		RetAlleyOrderIndexInvalid,
		// Token: 0x04003FEC RID: 16364
		[OriginalName("RET_ALLEY_REWARD_ALREADY_TAKE")]
		RetAlleyRewardAlreadyTake,
		// Token: 0x04003FED RID: 16365
		[OriginalName("RET_ALLEY_REWARD_NOT_EXIST")]
		RetAlleyRewardNotExist,
		// Token: 0x04003FEE RID: 16366
		[OriginalName("RET_ALLEY_MAIN_MISSION_NOT_DOING")]
		RetAlleyMainMissionNotDoing,
		// Token: 0x04003FEF RID: 16367
		[OriginalName("RET_ALLEY_CRITICAL_EVENT_NOT_FINISH")]
		RetAlleyCriticalEventNotFinish,
		// Token: 0x04003FF0 RID: 16368
		[OriginalName("RET_ALLEY_SHOP_GOODS_NOT_VALID")]
		RetAlleyShopGoodsNotValid,
		// Token: 0x04003FF1 RID: 16369
		[OriginalName("RET_ALLEY_SLASH_NOT_OPEN")]
		RetAlleySlashNotOpen,
		// Token: 0x04003FF2 RID: 16370
		[OriginalName("RET_ALLEY_PLACING_ANCHOR_INVALID")]
		RetAlleyPlacingAnchorInvalid,
		// Token: 0x04003FF3 RID: 16371
		[OriginalName("RET_ALLEY_PLACING_GOODS_INDEX_INVALID")]
		RetAlleyPlacingGoodsIndexInvalid,
		// Token: 0x04003FF4 RID: 16372
		[OriginalName("RET_ALLEY_SAVE_MAP_TOO_QUICK")]
		RetAlleySaveMapTooQuick,
		// Token: 0x04003FF5 RID: 16373
		[OriginalName("RET_ALLEY_MAP_NOT_LINK")]
		RetAlleyMapNotLink,
		// Token: 0x04003FF6 RID: 16374
		[OriginalName("RET_ALLEY_FUNDS_NOT_LOWER_BASE")]
		RetAlleyFundsNotLowerBase,
		// Token: 0x04003FF7 RID: 16375
		[OriginalName("RET_ALLEY_EVENT_NOT_FINISH")]
		RetAlleyEventNotFinish,
		// Token: 0x04003FF8 RID: 16376
		[OriginalName("RET_ALLEY_NORMAL_ORDER_NOT_MEET")]
		RetAlleyNormalOrderNotMeet,
		// Token: 0x04003FF9 RID: 16377
		[OriginalName("RET_PLAYER_RETURN_NOT_OPEN")]
		RetPlayerReturnNotOpen = 4801,
		// Token: 0x04003FFA RID: 16378
		[OriginalName("RET_PLAYER_RETURN_IS_SIGNED")]
		RetPlayerReturnIsSigned,
		// Token: 0x04003FFB RID: 16379
		[OriginalName("RET_PLAYER_RETURN_POINT_NOT_ENOUGH")]
		RetPlayerReturnPointNotEnough,
		// Token: 0x04003FFC RID: 16380
		[OriginalName("RET_PLAYER_RETURN_CONDITION_INVALID")]
		RetPlayerReturnConditionInvalid,
		// Token: 0x04003FFD RID: 16381
		[OriginalName("RET_PLAYER_RETURN_HAS_SIGNED")]
		RetPlayerReturnHasSigned,
		// Token: 0x04003FFE RID: 16382
		[OriginalName("RET_PLAYER_RETURN_REWARD_TAKEN")]
		RetPlayerReturnRewardTaken,
		// Token: 0x04003FFF RID: 16383
		[OriginalName("RET_AETHER_DIVIDE_NO_LINEUP")]
		RetAetherDivideNoLineup = 4851,
		// Token: 0x04004000 RID: 16384
		[OriginalName("RET_AETHER_DIVIDE_LINEUP_INVALID")]
		RetAetherDivideLineupInvalid,
		// Token: 0x04004001 RID: 16385
		[OriginalName("RET_CHAT_BUBBLE_ID_ERROR")]
		RetChatBubbleIdError = 4901,
		// Token: 0x04004002 RID: 16386
		[OriginalName("RET_CHAT_BUBBLE_ID_NOT_UNLOCK")]
		RetChatBubbleIdNotUnlock,
		// Token: 0x04004003 RID: 16387
		[OriginalName("RET_PHONE_THEME_ID_ERROR")]
		RetPhoneThemeIdError,
		// Token: 0x04004004 RID: 16388
		[OriginalName("RET_PHONE_THEME_ID_NOT_UNLOCK")]
		RetPhoneThemeIdNotUnlock,
		// Token: 0x04004005 RID: 16389
		[OriginalName("RET_CHAT_BUBBLE_SELECT_IS_CURRENT")]
		RetChatBubbleSelectIsCurrent,
		// Token: 0x04004006 RID: 16390
		[OriginalName("RET_PHONE_THEME_SELECT_IS_CURRENT")]
		RetPhoneThemeSelectIsCurrent,
		// Token: 0x04004007 RID: 16391
		[OriginalName("RET_CHESS_ROGUE_CONFIG_NOT_FOUND")]
		RetChessRogueConfigNotFound = 4951,
		// Token: 0x04004008 RID: 16392
		[OriginalName("RET_CHESS_ROGUE_CONFIG_INVALID")]
		RetChessRogueConfigInvalid,
		// Token: 0x04004009 RID: 16393
		[OriginalName("RET_CHESS_ROGUE_NO_VALID_ROOM")]
		RetChessRogueNoValidRoom = 4963,
		// Token: 0x0400400A RID: 16394
		[OriginalName("RET_CHESS_ROGUE_NO_CELL_INFO")]
		RetChessRogueNoCellInfo,
		// Token: 0x0400400B RID: 16395
		[OriginalName("RET_CHESS_ROGUE_CELL_NOT_FINISH")]
		RetChessRogueCellNotFinish,
		// Token: 0x0400400C RID: 16396
		[OriginalName("RET_CHESS_ROGUE_CELL_IS_LOCKED")]
		RetChessRogueCellIsLocked,
		// Token: 0x0400400D RID: 16397
		[OriginalName("RET_CHESS_ROGUE_SCHEDULE_NOT_MATCH")]
		RetChessRogueScheduleNotMatch,
		// Token: 0x0400400E RID: 16398
		[OriginalName("RET_CHESS_ROGUE_STATUS_FAIL")]
		RetChessRogueStatusFail,
		// Token: 0x0400400F RID: 16399
		[OriginalName("RET_CHESS_ROGUE_AREA_NOT_EXIST")]
		RetChessRogueAreaNotExist,
		// Token: 0x04004010 RID: 16400
		[OriginalName("RET_CHESS_ROGUE_LINEUP_FAIL")]
		RetChessRogueLineupFail,
		// Token: 0x04004011 RID: 16401
		[OriginalName("RET_CHESS_ROGUE_AEON_FAIL")]
		RetChessRogueAeonFail = 4980,
		// Token: 0x04004012 RID: 16402
		[OriginalName("RET_CHESS_ROGUE_ENTER_CELL_FAIL")]
		RetChessRogueEnterCellFail,
		// Token: 0x04004013 RID: 16403
		[OriginalName("RET_CHESS_ROGUE_ROLL_DICE_FAIL")]
		RetChessRogueRollDiceFail,
		// Token: 0x04004014 RID: 16404
		[OriginalName("RET_CHESS_ROGUE_DICE_STATUS_FAIL")]
		RetChessRogueDiceStatusFail,
		// Token: 0x04004015 RID: 16405
		[OriginalName("RET_CHESS_ROGUE_DICE_CNT_NOT_FULL")]
		RetChessRogueDiceCntNotFull,
		// Token: 0x04004016 RID: 16406
		[OriginalName("RET_CHESS_ROGUE_UNLOCK")]
		RetChessRogueUnlock,
		// Token: 0x04004017 RID: 16407
		[OriginalName("RET_CHESS_ROGUE_PICK_AVATAR_FAIL")]
		RetChessRoguePickAvatarFail,
		// Token: 0x04004018 RID: 16408
		[OriginalName("RET_CHESS_ROGUE_AVATAR_INVALID")]
		RetChessRogueAvatarInvalid,
		// Token: 0x04004019 RID: 16409
		[OriginalName("RET_CHESS_ROGUE_CELL_CAN_NOT_SELECT")]
		RetChessRogueCellCanNotSelect,
		// Token: 0x0400401A RID: 16410
		[OriginalName("RET_CHESS_ROGUE_DICE_CONFIRMED")]
		RetChessRogueDiceConfirmed,
		// Token: 0x0400401B RID: 16411
		[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_NOT_MATCH")]
		RetChessRogueNousDiceNotMatch,
		// Token: 0x0400401C RID: 16412
		[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_RARITY_FAIL")]
		RetChessRogueNousDiceRarityFail,
		// Token: 0x0400401D RID: 16413
		[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_SURFACE_DUPLICATE")]
		RetChessRogueNousDiceSurfaceDuplicate,
		// Token: 0x0400401E RID: 16414
		[OriginalName("RET_CHESS_ROGUE_NOT_IN_ROGUE")]
		RetChessRogueNotInRogue,
		// Token: 0x0400401F RID: 16415
		[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_BRANCH_LIMIT")]
		RetChessRogueNousDiceBranchLimit,
		// Token: 0x04004020 RID: 16416
		[OriginalName("RET_HELIOBUS_NOT_OPEN")]
		RetHeliobusNotOpen = 5101,
		// Token: 0x04004021 RID: 16417
		[OriginalName("RET_HELIOBUS_SNS_POST_NOT_UNLOCK")]
		RetHeliobusSnsPostNotUnlock,
		// Token: 0x04004022 RID: 16418
		[OriginalName("RET_HELIOBUS_SNS_ALREADY_READ")]
		RetHeliobusSnsAlreadyRead,
		// Token: 0x04004023 RID: 16419
		[OriginalName("RET_HELIOBUS_SNS_ALREADY_LIKED")]
		RetHeliobusSnsAlreadyLiked,
		// Token: 0x04004024 RID: 16420
		[OriginalName("RET_HELIOBUS_SNS_ALREADY_COMMENTED")]
		RetHeliobusSnsAlreadyCommented,
		// Token: 0x04004025 RID: 16421
		[OriginalName("RET_HELIOBUS_SNS_IN_MISSION")]
		RetHeliobusSnsInMission,
		// Token: 0x04004026 RID: 16422
		[OriginalName("RET_HELIOBUS_SNS_ALREADY_POSTED")]
		RetHeliobusSnsAlreadyPosted,
		// Token: 0x04004027 RID: 16423
		[OriginalName("RET_HELIOBUS_SNS_NOT_DOING_MISSION")]
		RetHeliobusSnsNotDoingMission,
		// Token: 0x04004028 RID: 16424
		[OriginalName("RET_HELIOBUS_REWARD_LEVEL_MAX")]
		RetHeliobusRewardLevelMax,
		// Token: 0x04004029 RID: 16425
		[OriginalName("RET_HELIOBUS_INCOME_NOT_ENOUGH")]
		RetHeliobusIncomeNotEnough,
		// Token: 0x0400402A RID: 16426
		[OriginalName("RET_HELIOBUS_SNS_COMMENT_NOT_UNLOCK")]
		RetHeliobusSnsCommentNotUnlock,
		// Token: 0x0400402B RID: 16427
		[OriginalName("RET_HELIOBUS_CHALLENGE_NOT_UNLOCK")]
		RetHeliobusChallengeNotUnlock,
		// Token: 0x0400402C RID: 16428
		[OriginalName("RET_HELIOBUS_CHALLENGE_ID_ERROR")]
		RetHeliobusChallengeIdError,
		// Token: 0x0400402D RID: 16429
		[OriginalName("RET_HELIOBUS_SKILL_NOT_UNLOCK")]
		RetHeliobusSkillNotUnlock,
		// Token: 0x0400402E RID: 16430
		[OriginalName("RET_HELIOBUS_ACCEPT_POST_MISSION_FAIL")]
		RetHeliobusAcceptPostMissionFail,
		// Token: 0x0400402F RID: 16431
		[OriginalName("RET_HELIOBUS_SKILL_NOT_SELECTED")]
		RetHeliobusSkillNotSelected,
		// Token: 0x04004030 RID: 16432
		[OriginalName("RET_HELIOBUS_PLANE_TYPE_INVALID")]
		RetHeliobusPlaneTypeInvalid,
		// Token: 0x04004031 RID: 16433
		[OriginalName("RET_REDDOT_PARAM_INVALID")]
		RetReddotParamInvalid = 5151,
		// Token: 0x04004032 RID: 16434
		[OriginalName("RET_REDDOT_ACTIVITY_NOT_OPEN")]
		RetReddotActivityNotOpen,
		// Token: 0x04004033 RID: 16435
		[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_CONFIG_ERROR")]
		RetRogueEndlessActivityConfigError = 5201,
		// Token: 0x04004034 RID: 16436
		[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_NOT_OPEN")]
		RetRogueEndlessActivityNotOpen,
		// Token: 0x04004035 RID: 16437
		[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_OVER_BONUS_REWARD_LIMIT")]
		RetRogueEndlessActivityOverBonusRewardLimit,
		// Token: 0x04004036 RID: 16438
		[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_SCORE_NOT_MEET")]
		RetRogueEndlessActivityScoreNotMeet,
		// Token: 0x04004037 RID: 16439
		[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_REWARD_LEVLE_ALREADY_TAKE")]
		RetRogueEndlessActivityRewardLevleAlreadyTake,
		// Token: 0x04004038 RID: 16440
		[OriginalName("RET_HEART_DIAL_SCRIPT_NOT_FOUND")]
		RetHeartDialScriptNotFound = 5251,
		// Token: 0x04004039 RID: 16441
		[OriginalName("RET_HEART_DIAL_SCRIPT_EMOTION_THE_SAME")]
		RetHeartDialScriptEmotionTheSame,
		// Token: 0x0400403A RID: 16442
		[OriginalName("RET_HEART_DIAL_SCRIPT_STEP_NOT_NORMAL")]
		RetHeartDialScriptStepNotNormal,
		// Token: 0x0400403B RID: 16443
		[OriginalName("RET_HEART_DIAL_SCRIPT_CONDITION_NOT_MATCH")]
		RetHeartDialScriptConditionNotMatch,
		// Token: 0x0400403C RID: 16444
		[OriginalName("RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_NUM_NOT_MATCH")]
		RetHeartDialScriptSubmitItemNumNotMatch,
		// Token: 0x0400403D RID: 16445
		[OriginalName("RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_ID_NOT_MATCH")]
		RetHeartDialScriptSubmitItemIdNotMatch,
		// Token: 0x0400403E RID: 16446
		[OriginalName("RET_HEART_DIAL_DIALOGUE_NOT_FOUND")]
		RetHeartDialDialogueNotFound,
		// Token: 0x0400403F RID: 16447
		[OriginalName("RET_HEART_DIAL_DIALOGUE_ALREADY_PERFORMED")]
		RetHeartDialDialogueAlreadyPerformed,
		// Token: 0x04004040 RID: 16448
		[OriginalName("RET_HEART_DIAL_NPC_NOT_FOUND")]
		RetHeartDialNpcNotFound,
		// Token: 0x04004041 RID: 16449
		[OriginalName("RET_HEART_DIAL_TRACE_CONFIG_NOT_FOUND")]
		RetHeartDialTraceConfigNotFound,
		// Token: 0x04004042 RID: 16450
		[OriginalName("RET_HEART_DIAL_FLOOR_TRACE_EXIST")]
		RetHeartDialFloorTraceExist,
		// Token: 0x04004043 RID: 16451
		[OriginalName("RET_HEART_DIAL_TRACE_FLOOR_NOT_MATCH")]
		RetHeartDialTraceFloorNotMatch,
		// Token: 0x04004044 RID: 16452
		[OriginalName("RET_TRAVEL_BROCHURE_CONFIG_ERROR")]
		RetTravelBrochureConfigError = 5301,
		// Token: 0x04004045 RID: 16453
		[OriginalName("RET_TRAVEL_BROCHURE_PARAM_INVALID")]
		RetTravelBrochureParamInvalid,
		// Token: 0x04004046 RID: 16454
		[OriginalName("RET_TRAVEL_BROCHURE_LOCKED")]
		RetTravelBrochureLocked,
		// Token: 0x04004047 RID: 16455
		[OriginalName("RET_TRAVEL_BROCHURE_CANNOT_OPERATE")]
		RetTravelBrochureCannotOperate,
		// Token: 0x04004048 RID: 16456
		[OriginalName("RET_TRAVEL_BROCHURE_WORLD_ID_NOT_MATCH")]
		RetTravelBrochureWorldIdNotMatch,
		// Token: 0x04004049 RID: 16457
		[OriginalName("RET_TRAVEL_BROCHURE_HAS_NO_WORLD_BOOK")]
		RetTravelBrochureHasNoWorldBook,
		// Token: 0x0400404A RID: 16458
		[OriginalName("RET_TRAVEL_BROCHURE_PAGE_FULL")]
		RetTravelBrochurePageFull,
		// Token: 0x0400404B RID: 16459
		[OriginalName("RET_MAP_ROTATION_NOT_IN_REGION")]
		RetMapRotationNotInRegion = 5351,
		// Token: 0x0400404C RID: 16460
		[OriginalName("RET_MAP_ROTATION_ROTATER_ALREADY_DEPLOYED")]
		RetMapRotationRotaterAlreadyDeployed,
		// Token: 0x0400404D RID: 16461
		[OriginalName("RET_MAP_ROTATION_ENERGY_NOT_ENOUGH")]
		RetMapRotationEnergyNotEnough,
		// Token: 0x0400404E RID: 16462
		[OriginalName("RET_MAP_ROTATION_ENTITY_NOT_ON_CUR_POSE")]
		RetMapRotationEntityNotOnCurPose,
		// Token: 0x0400404F RID: 16463
		[OriginalName("RET_MAP_ROTATION_ROTATER_NOT_DEPLOYED")]
		RetMapRotationRotaterNotDeployed,
		// Token: 0x04004050 RID: 16464
		[OriginalName("RET_MAP_ROTATION_POSE_ROTATER_MISMATCH")]
		RetMapRotationPoseRotaterMismatch,
		// Token: 0x04004051 RID: 16465
		[OriginalName("RET_MAP_ROTATION_ROTATER_NOT_REMOVABLE")]
		RetMapRotationRotaterNotRemovable,
		// Token: 0x04004052 RID: 16466
		[OriginalName("RET_MAP_ROTATION_ROTATER_DISPOSABLE")]
		RetMapRotationRotaterDisposable,
		// Token: 0x04004053 RID: 16467
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_NOT_FOUND")]
		RetSpaceZooActivityCatNotFound = 5401,
		// Token: 0x04004054 RID: 16468
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_PARAM_INVALID")]
		RetSpaceZooActivityCatParamInvalid,
		// Token: 0x04004055 RID: 16469
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_ITEM_NOT_ENOUGH")]
		RetSpaceZooActivityCatItemNotEnough,
		// Token: 0x04004056 RID: 16470
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_BAG_FULL")]
		RetSpaceZooActivityCatBagFull,
		// Token: 0x04004057 RID: 16471
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_NOT_TO_MUTATE")]
		RetSpaceZooActivityCatNotToMutate,
		// Token: 0x04004058 RID: 16472
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_STATE_ERROR")]
		RetSpaceZooActivityCatStateError,
		// Token: 0x04004059 RID: 16473
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_CATTERY_LOCKED")]
		RetSpaceZooActivityCatCatteryLocked,
		// Token: 0x0400405A RID: 16474
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_OUT_NOW")]
		RetSpaceZooActivityCatOutNow,
		// Token: 0x0400405B RID: 16475
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_CONFIG_NOT_FOUND")]
		RetSpaceZooActivityCatConfigNotFound,
		// Token: 0x0400405C RID: 16476
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_FEATURE_NOT_FOUND")]
		RetSpaceZooActivityCatFeatureNotFound,
		// Token: 0x0400405D RID: 16477
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_ADD_CAT_ERROR")]
		RetSpaceZooActivityCatAddCatError,
		// Token: 0x0400405E RID: 16478
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_MONEY_NOT_ENOUGH")]
		RetSpaceZooActivityCatMoneyNotEnough,
		// Token: 0x0400405F RID: 16479
		[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_COND_NOT_MATCH")]
		RetSpaceZooActivityCatCondNotMatch,
		// Token: 0x04004060 RID: 16480
		[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_STAGE_CFG_MISS")]
		RetStrongChallengeActivityStageCfgMiss = 5501,
		// Token: 0x04004061 RID: 16481
		[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_STAGE_NOT_OPEN")]
		RetStrongChallengeActivityStageNotOpen,
		// Token: 0x04004062 RID: 16482
		[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_BUFF_ERROR")]
		RetStrongChallengeActivityBuffError,
		// Token: 0x04004063 RID: 16483
		[OriginalName("RET_ROLL_SHOP_NOT_FOUND")]
		RetRollShopNotFound = 5551,
		// Token: 0x04004064 RID: 16484
		[OriginalName("RET_ROLL_SHOP_GROUP_EMPTY")]
		RetRollShopGroupEmpty,
		// Token: 0x04004065 RID: 16485
		[OriginalName("RET_ROLL_SHOP_EMPTY")]
		RetRollShopEmpty,
		// Token: 0x04004066 RID: 16486
		[OriginalName("RET_ROLL_SHOP_GACHA_REQ_DUPLICATED")]
		RetRollShopGachaReqDuplicated,
		// Token: 0x04004067 RID: 16487
		[OriginalName("RET_ROLL_SHOP_RANDOM_ERROR")]
		RetRollShopRandomError,
		// Token: 0x04004068 RID: 16488
		[OriginalName("RET_ROLL_SHOP_GROUP_TYPE_NOT_FOUND")]
		RetRollShopGroupTypeNotFound,
		// Token: 0x04004069 RID: 16489
		[OriginalName("RET_ROLL_SHOP_HAS_STORED_REWARD_ALREADY")]
		RetRollShopHasStoredRewardAlready,
		// Token: 0x0400406A RID: 16490
		[OriginalName("RET_ROLL_SHOP_NO_STORED_REWARD")]
		RetRollShopNoStoredReward,
		// Token: 0x0400406B RID: 16491
		[OriginalName("RET_ROLL_SHOP_NOT_IN_VALID_SCENE")]
		RetRollShopNotInValidScene,
		// Token: 0x0400406C RID: 16492
		[OriginalName("RET_ROLL_SHOP_INVALID_ROLL_SHOP_TYPE")]
		RetRollShopInvalidRollShopType,
		// Token: 0x0400406D RID: 16493
		[OriginalName("RET_ACTIVITY_RAID_COLLECTION_PREV_NOT_FINISH")]
		RetActivityRaidCollectionPrevNotFinish = 5601,
		// Token: 0x0400406E RID: 16494
		[OriginalName("RET_ACTIVITY_RAID_COLLECTION_GROUP_ENTER_NEXT_UNAVAILABLE")]
		RetActivityRaidCollectionGroupEnterNextUnavailable,
		// Token: 0x0400406F RID: 16495
		[OriginalName("RET_ACTIVITY_RAID_COLLECTION_IS_LAST")]
		RetActivityRaidCollectionIsLast,
		// Token: 0x04004070 RID: 16496
		[OriginalName("RET_ACTIVITY_RAID_COLLECTION_IS_NOT_NEXT")]
		RetActivityRaidCollectionIsNotNext,
		// Token: 0x04004071 RID: 16497
		[OriginalName("RET_OFFERING_NOT_UNLOCK")]
		RetOfferingNotUnlock = 5651,
		// Token: 0x04004072 RID: 16498
		[OriginalName("RET_OFFERING_LEVEL_NOT_UNLOCK")]
		RetOfferingLevelNotUnlock,
		// Token: 0x04004073 RID: 16499
		[OriginalName("RET_OFFERING_REACH_MAX_LEVEL")]
		RetOfferingReachMaxLevel,
		// Token: 0x04004074 RID: 16500
		[OriginalName("RET_OFFERING_ITEM_NOT_ENOUGH")]
		RetOfferingItemNotEnough,
		// Token: 0x04004075 RID: 16501
		[OriginalName("RET_OFFERING_LONGTAIL_NOT_OPEN")]
		RetOfferingLongtailNotOpen,
		// Token: 0x04004076 RID: 16502
		[OriginalName("RET_OFFERING_REWARD_CONDITION")]
		RetOfferingRewardCondition,
		// Token: 0x04004077 RID: 16503
		[OriginalName("RET_DRINK_MAKER_CHAT_INVALID")]
		RetDrinkMakerChatInvalid = 5701,
		// Token: 0x04004078 RID: 16504
		[OriginalName("RET_DRINK_MAKER_PARAM_INVALID")]
		RetDrinkMakerParamInvalid,
		// Token: 0x04004079 RID: 16505
		[OriginalName("RET_DRINK_MAKER_PARAM_NOT_UNLOCK")]
		RetDrinkMakerParamNotUnlock,
		// Token: 0x0400407A RID: 16506
		[OriginalName("RET_DRINK_MAKER_CONFIG_NOT_FOUND")]
		RetDrinkMakerConfigNotFound,
		// Token: 0x0400407B RID: 16507
		[OriginalName("RET_DRINK_MAKER_NOT_LAST_CHAT")]
		RetDrinkMakerNotLastChat,
		// Token: 0x0400407C RID: 16508
		[OriginalName("RET_DRINK_MAKER_DAY_AND_FREE_PHASE_NOT_OPEN")]
		RetDrinkMakerDayAndFreePhaseNotOpen,
		// Token: 0x0400407D RID: 16509
		[OriginalName("RET_MONOPOLY_NOT_OPEN")]
		RetMonopolyNotOpen = 5751,
		// Token: 0x0400407E RID: 16510
		[OriginalName("RET_MONOPOLY_CONFIG_ERROR")]
		RetMonopolyConfigError,
		// Token: 0x0400407F RID: 16511
		[OriginalName("RET_MONOPOLY_DICE_NOT_ENOUGH")]
		RetMonopolyDiceNotEnough,
		// Token: 0x04004080 RID: 16512
		[OriginalName("RET_MONOPOLY_CUR_CELL_NOT_FINISH")]
		RetMonopolyCurCellNotFinish,
		// Token: 0x04004081 RID: 16513
		[OriginalName("RET_MONOPOLY_COIN_NOT_ENOUGH")]
		RetMonopolyCoinNotEnough,
		// Token: 0x04004082 RID: 16514
		[OriginalName("RET_MONOPOLY_CELL_WAIT_PENDING")]
		RetMonopolyCellWaitPending,
		// Token: 0x04004083 RID: 16515
		[OriginalName("RET_MONOPOLY_CELL_STATE_ERROR")]
		RetMonopolyCellStateError,
		// Token: 0x04004084 RID: 16516
		[OriginalName("RET_MONOPOLY_CELL_CONTENT_ERROR")]
		RetMonopolyCellContentError,
		// Token: 0x04004085 RID: 16517
		[OriginalName("RET_MONOPOLY_ITEM_NOT_ENOUGH")]
		RetMonopolyItemNotEnough,
		// Token: 0x04004086 RID: 16518
		[OriginalName("RET_MONOPOLY_CELL_CONTENT_CANNOT_GIVEUP")]
		RetMonopolyCellContentCannotGiveup,
		// Token: 0x04004087 RID: 16519
		[OriginalName("RET_MONOPOLY_ASSET_LEVEL_INVALID")]
		RetMonopolyAssetLevelInvalid,
		// Token: 0x04004088 RID: 16520
		[OriginalName("RET_MONOPOLY_TURN_NOT_FINISH")]
		RetMonopolyTurnNotFinish,
		// Token: 0x04004089 RID: 16521
		[OriginalName("RET_MONOPOLY_GUIDE_NOT_FINISH")]
		RetMonopolyGuideNotFinish,
		// Token: 0x0400408A RID: 16522
		[OriginalName("RET_MONOPOLY_RAFFLE_REWARD_REISSUED")]
		RetMonopolyRaffleRewardReissued,
		// Token: 0x0400408B RID: 16523
		[OriginalName("RET_MONOPOLY_NO_GAME_ACTIVE")]
		RetMonopolyNoGameActive = 5771,
		// Token: 0x0400408C RID: 16524
		[OriginalName("RET_MONOPOLY_GAME_RATIO_NOT_INCREASABLE")]
		RetMonopolyGameRatioNotIncreasable,
		// Token: 0x0400408D RID: 16525
		[OriginalName("RET_MONOPOLY_GAME_RATIO_MAX")]
		RetMonopolyGameRatioMax,
		// Token: 0x0400408E RID: 16526
		[OriginalName("RET_MONOPOLY_GAME_TARGET_RATIO_INVALID")]
		RetMonopolyGameTargetRatioInvalid,
		// Token: 0x0400408F RID: 16527
		[OriginalName("RET_MONOPOLY_GAME_BINGO_FLIP_POS_INVALID")]
		RetMonopolyGameBingoFlipPosInvalid,
		// Token: 0x04004090 RID: 16528
		[OriginalName("RET_MONOPOLY_GAME_GUESS_ALREADY_CHOOSE")]
		RetMonopolyGameGuessAlreadyChoose,
		// Token: 0x04004091 RID: 16529
		[OriginalName("RET_MONOPOLY_GAME_GUESS_CHOOSE_INVALID")]
		RetMonopolyGameGuessChooseInvalid,
		// Token: 0x04004092 RID: 16530
		[OriginalName("RET_MONOPOLY_GAME_GUESS_INFORMATION_ALREADY_BOUGHT")]
		RetMonopolyGameGuessInformationAlreadyBought,
		// Token: 0x04004093 RID: 16531
		[OriginalName("RET_MONOPOLY_GAME_RAISE_RATIO_NOT_UNLOCK")]
		RetMonopolyGameRaiseRatioNotUnlock,
		// Token: 0x04004094 RID: 16532
		[OriginalName("RET_MONOPOLY_FRIEND_NOT_SYNCED")]
		RetMonopolyFriendNotSynced = 5785,
		// Token: 0x04004095 RID: 16533
		[OriginalName("RET_MONOPOLY_GET_FRIEND_RANKING_LIST_IN_CD")]
		RetMonopolyGetFriendRankingListInCd,
		// Token: 0x04004096 RID: 16534
		[OriginalName("RET_MONOPOLY_LIKE_TARGET_NOT_FRIEND")]
		RetMonopolyLikeTargetNotFriend,
		// Token: 0x04004097 RID: 16535
		[OriginalName("RET_MONOPOLY_DAILY_ALREADY_LIKED")]
		RetMonopolyDailyAlreadyLiked,
		// Token: 0x04004098 RID: 16536
		[OriginalName("RET_MONOPOLY_SOCIAL_EVENT_STATUS_NOT_MATCH")]
		RetMonopolySocialEventStatusNotMatch,
		// Token: 0x04004099 RID: 16537
		[OriginalName("RET_MONOPOLY_SOCIAL_EVENT_SERVER_CACHE_NOT_EXIST")]
		RetMonopolySocialEventServerCacheNotExist,
		// Token: 0x0400409A RID: 16538
		[OriginalName("RET_MONOPOLY_ACTIVITY_ID_NOT_MATCH")]
		RetMonopolyActivityIdNotMatch,
		// Token: 0x0400409B RID: 16539
		[OriginalName("RET_MONOPOLY_RAFFLE_POOL_NOT_EXIST")]
		RetMonopolyRafflePoolNotExist,
		// Token: 0x0400409C RID: 16540
		[OriginalName("RET_MONOPOLY_RAFFLE_POOL_TIME_NOT_MATCH")]
		RetMonopolyRafflePoolTimeNotMatch,
		// Token: 0x0400409D RID: 16541
		[OriginalName("RET_MONOPOLY_RAFFLE_POOL_PHASE_NOT_MEET")]
		RetMonopolyRafflePoolPhaseNotMeet,
		// Token: 0x0400409E RID: 16542
		[OriginalName("RET_MONOPOLY_RAFFLE_POOL_SHOW_TIME_NOT_MEET")]
		RetMonopolyRafflePoolShowTimeNotMeet,
		// Token: 0x0400409F RID: 16543
		[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_NOT_FOUND")]
		RetMonopolyRaffleTicketNotFound,
		// Token: 0x040040A0 RID: 16544
		[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_TIME_NOT_MEET")]
		RetMonopolyRaffleTicketTimeNotMeet,
		// Token: 0x040040A1 RID: 16545
		[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_REWARD_ALREADY_TAKEN")]
		RetMonopolyRaffleTicketRewardAlreadyTaken,
		// Token: 0x040040A2 RID: 16546
		[OriginalName("RET_MONOPOLY_RAFFLE_POOL_NOT_IN_RAFFLE_TIME")]
		RetMonopolyRafflePoolNotInRaffleTime,
		// Token: 0x040040A3 RID: 16547
		[OriginalName("RET_MONOPOLY_MBTI_REPORT_REWARD_ALREADY_TAKEN")]
		RetMonopolyMbtiReportRewardAlreadyTaken,
		// Token: 0x040040A4 RID: 16548
		[OriginalName("RET_EVOLVE_BUILD_LEVEL_GAMING")]
		RetEvolveBuildLevelGaming,
		// Token: 0x040040A5 RID: 16549
		[OriginalName("RET_EVEOLVE_BUILD_LEVEL_BAN_RANDOM")]
		RetEveolveBuildLevelBanRandom,
		// Token: 0x040040A6 RID: 16550
		[OriginalName("RET_EVOLVE_BUILD_FIRST_REWARD_ALREADY_TAKEN")]
		RetEvolveBuildFirstRewardAlreadyTaken,
		// Token: 0x040040A7 RID: 16551
		[OriginalName("RET_EVOLVE_BUILD_LEVEL_UNFINISH")]
		RetEvolveBuildLevelUnfinish,
		// Token: 0x040040A8 RID: 16552
		[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_MAX_LEVEL")]
		RetEvolveBuildShopAbilityMaxLevel,
		// Token: 0x040040A9 RID: 16553
		[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_MIN_LEVEL")]
		RetEvolveBuildShopAbilityMinLevel,
		// Token: 0x040040AA RID: 16554
		[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_NOT_GET")]
		RetEvolveBuildShopAbilityNotGet,
		// Token: 0x040040AB RID: 16555
		[OriginalName("RET_EVOLVE_BUILD_LEVEL_LOCK")]
		RetEvolveBuildLevelLock,
		// Token: 0x040040AC RID: 16556
		[OriginalName("RET_EVOLVE_BUILD_EXP_NOT_ENOUGH")]
		RetEvolveBuildExpNotEnough,
		// Token: 0x040040AD RID: 16557
		[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_LEVEL_ERROR")]
		RetEvolveBuildShopAbilityLevelError,
		// Token: 0x040040AE RID: 16558
		[OriginalName("RET_EVOLVE_BUILD_ACTIVITY_NOT_OPEN")]
		RetEvolveBuildActivityNotOpen,
		// Token: 0x040040AF RID: 16559
		[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_EMPTY")]
		RetEvolveBuildShopAbilityEmpty,
		// Token: 0x040040B0 RID: 16560
		[OriginalName("RET_EVOLVE_BUILD_LEVEL_NOT_START")]
		RetEvolveBuildLevelNotStart,
		// Token: 0x040040B1 RID: 16561
		[OriginalName("RET_EVOLVE_BUILD_SHOP_LOCK")]
		RetEvolveBuildShopLock,
		// Token: 0x040040B2 RID: 16562
		[OriginalName("RET_EVOLVE_BUILD_REWARD_LOCK")]
		RetEvolveBuildRewardLock,
		// Token: 0x040040B3 RID: 16563
		[OriginalName("RET_EVOLVE_BUILD_REWARD_LEVEL_MAX")]
		RetEvolveBuildRewardLevelMax,
		// Token: 0x040040B4 RID: 16564
		[OriginalName("RET_EVOLVE_BUILD_REWARD_ALREADY_ALL_TAKEN")]
		RetEvolveBuildRewardAlreadyAllTaken = 5717,
		// Token: 0x040040B5 RID: 16565
		[OriginalName("RET_CLOCK_PARK_CONFIG_ERROR")]
		RetClockParkConfigError = 5851,
		// Token: 0x040040B6 RID: 16566
		[OriginalName("RET_CLOCK_PARK_EFFECT_ERROR")]
		RetClockParkEffectError,
		// Token: 0x040040B7 RID: 16567
		[OriginalName("RET_CLOCK_PARK_SCRIPT_ALREADY_UNLOCK")]
		RetClockParkScriptAlreadyUnlock,
		// Token: 0x040040B8 RID: 16568
		[OriginalName("RET_CLOCK_PARK_SCRIPT_UNLOCK_CONDITION_NOT_MEET")]
		RetClockParkScriptUnlockConditionNotMeet,
		// Token: 0x040040B9 RID: 16569
		[OriginalName("RET_CLOCK_PARK_TALENT_ALREADY_UNLOCK")]
		RetClockParkTalentAlreadyUnlock,
		// Token: 0x040040BA RID: 16570
		[OriginalName("RET_CLOCK_PARK_SCRIPT_LOCKED")]
		RetClockParkScriptLocked,
		// Token: 0x040040BB RID: 16571
		[OriginalName("RET_CLOCK_PARK_HAS_ONGOING_SCRIPT")]
		RetClockParkHasOngoingScript,
		// Token: 0x040040BC RID: 16572
		[OriginalName("RET_CLOCK_PARK_NO_ONGOING_SCRIPT")]
		RetClockParkNoOngoingScript,
		// Token: 0x040040BD RID: 16573
		[OriginalName("RET_CLOCK_PARK_DICE_PLACEMENT_ERROR")]
		RetClockParkDicePlacementError,
		// Token: 0x040040BE RID: 16574
		[OriginalName("RET_CLOCK_PARK_MISMATCH_STATUS")]
		RetClockParkMismatchStatus,
		// Token: 0x040040BF RID: 16575
		[OriginalName("RET_CLOCK_PARK_NO_BUFF")]
		RetClockParkNoBuff,
		// Token: 0x040040C0 RID: 16576
		[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_GACHA_REQ_DUPLICATED")]
		RetClockParkSlotMachineGachaReqDuplicated,
		// Token: 0x040040C1 RID: 16577
		[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_COST_NOT_ENOUGH")]
		RetClockParkSlotMachineCostNotEnough,
		// Token: 0x040040C2 RID: 16578
		[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_GACHA_CNT_EXCEED_LIMIT")]
		RetClockParkSlotMachineGachaCntExceedLimit,
		// Token: 0x040040C3 RID: 16579
		[OriginalName("RET_CLOCK_PARK_NOT_OPEN")]
		RetClockParkNotOpen,
		// Token: 0x040040C4 RID: 16580
		[OriginalName("RET_TOURN_ROGUE_STATUS_MISMATCH")]
		RetTournRogueStatusMismatch = 5901,
		// Token: 0x040040C5 RID: 16581
		[OriginalName("RET_MAGIC_ROGUE_STATUS_MISMATCH")]
		RetMagicRogueStatusMismatch,
		// Token: 0x040040C6 RID: 16582
		[OriginalName("RET_MATCH_ALREADY_IN_MATCH")]
		RetMatchAlreadyInMatch = 6201,
		// Token: 0x040040C7 RID: 16583
		[OriginalName("RET_MATCH_NOT_IN_MATCH")]
		RetMatchNotInMatch,
		// Token: 0x040040C8 RID: 16584
		[OriginalName("RET_MATCH_PLAY_NOT_OPEN")]
		RetMatchPlayNotOpen,
		// Token: 0x040040C9 RID: 16585
		[OriginalName("RET_CROSS_STATE_ERROR")]
		RetCrossStateError,
		// Token: 0x040040CA RID: 16586
		[OriginalName("RET_MATCH_VERSION_NOT_EQUAL")]
		RetMatchVersionNotEqual,
		// Token: 0x040040CB RID: 16587
		[OriginalName("RET_MATCH_PLAYER_NOT_IN_LOBBY_ROOM")]
		RetMatchPlayerNotInLobbyRoom,
		// Token: 0x040040CC RID: 16588
		[OriginalName("RET_LOBBY_STATE_NOT_MATCH")]
		RetLobbyStateNotMatch,
		// Token: 0x040040CD RID: 16589
		[OriginalName("RET_LOBBY_ROOM_NOT_EXIST")]
		RetLobbyRoomNotExist,
		// Token: 0x040040CE RID: 16590
		[OriginalName("RET_LOBBY_ROOM_PALYER_FULL")]
		RetLobbyRoomPalyerFull,
		// Token: 0x040040CF RID: 16591
		[OriginalName("RET_LOBBY_ROOM_PALYER_NOT_READY")]
		RetLobbyRoomPalyerNotReady,
		// Token: 0x040040D0 RID: 16592
		[OriginalName("RET_LOBBY_ROOM_PALYER_FIGHTING")]
		RetLobbyRoomPalyerFighting,
		// Token: 0x040040D1 RID: 16593
		[OriginalName("RET_FIGHT_ROOM_NOT_EXIST")]
		RetFightRoomNotExist = 6250,
		// Token: 0x040040D2 RID: 16594
		[OriginalName("RET_FIGHT_MATCH3_PLAYER_STATE_ERR")]
		RetFightMatch3PlayerStateErr,
		// Token: 0x040040D3 RID: 16595
		[OriginalName("RET_FIGHT_MATCH3_ROOM_STATE_ERR")]
		RetFightMatch3RoomStateErr,
		// Token: 0x040040D4 RID: 16596
		[OriginalName("RET_SWORD_TRAINING_NO_ACTIVE_GAME")]
		RetSwordTrainingNoActiveGame = 6301,
		// Token: 0x040040D5 RID: 16597
		[OriginalName("RET_SWORD_TRAINING_NO_PENDING_ACTION_MATCH")]
		RetSwordTrainingNoPendingActionMatch,
		// Token: 0x040040D6 RID: 16598
		[OriginalName("RET_SWORD_TRAINING_PARTNER_ABILITY_INVALID")]
		RetSwordTrainingPartnerAbilityInvalid,
		// Token: 0x040040D7 RID: 16599
		[OriginalName("RET_SWORD_TRAINING_SKILL_ALREADY_LEARNED")]
		RetSwordTrainingSkillAlreadyLearned,
		// Token: 0x040040D8 RID: 16600
		[OriginalName("RET_SWORD_TRAINING_CONDITION_NOT_MEET")]
		RetSwordTrainingConditionNotMeet,
		// Token: 0x040040D9 RID: 16601
		[OriginalName("RET_SWORD_TRAINING_PARENT_SKILL_NOT_LEARNED")]
		RetSwordTrainingParentSkillNotLearned,
		// Token: 0x040040DA RID: 16602
		[OriginalName("RET_SWORD_TRAINING_SKILL_TYPE_NOT_UNLOCK")]
		RetSwordTrainingSkillTypeNotUnlock,
		// Token: 0x040040DB RID: 16603
		[OriginalName("RET_SWORD_TRAINING_GAME_ALREADY_EXIST")]
		RetSwordTrainingGameAlreadyExist,
		// Token: 0x040040DC RID: 16604
		[OriginalName("RET_SWORD_TRAINING_ENDING_HINT_NOT_MATCH")]
		RetSwordTrainingEndingHintNotMatch,
		// Token: 0x040040DD RID: 16605
		[OriginalName("RET_SWORD_TRAINING_STORYLINE_CONFIG_NOT_FOUND")]
		RetSwordTrainingStorylineConfigNotFound,
		// Token: 0x040040DE RID: 16606
		[OriginalName("RET_SWORD_TRAINING_STORY_CONFIG_NOT_FOUND")]
		RetSwordTrainingStoryConfigNotFound,
		// Token: 0x040040DF RID: 16607
		[OriginalName("RET_SWORD_TRAINING_UNLOCK_NOT_FINISH")]
		RetSwordTrainingUnlockNotFinish,
		// Token: 0x040040E0 RID: 16608
		[OriginalName("RET_SWORD_TRAINING_OPTION_MISMATCH")]
		RetSwordTrainingOptionMismatch,
		// Token: 0x040040E1 RID: 16609
		[OriginalName("RET_SWORD_TRAINING_RESTORE_WITHOUT_EXAM_FAILED")]
		RetSwordTrainingRestoreWithoutExamFailed,
		// Token: 0x040040E2 RID: 16610
		[OriginalName("RET_SWORD_TRAINING_NO_RESTORE_GAME_AVAILABLE")]
		RetSwordTrainingNoRestoreGameAvailable,
		// Token: 0x040040E3 RID: 16611
		[OriginalName("RET_SWORD_TRAINING_ENDING_STORY_NOT_MATCH")]
		RetSwordTrainingEndingStoryNotMatch,
		// Token: 0x040040E4 RID: 16612
		[OriginalName("RET_SWORD_TRAINING_ENDING_NOT_FINISH")]
		RetSwordTrainingEndingNotFinish,
		// Token: 0x040040E5 RID: 16613
		[OriginalName("RET_SWORD_TRAINING_ENDING_REWARD_TAKEN")]
		RetSwordTrainingEndingRewardTaken,
		// Token: 0x040040E6 RID: 16614
		[OriginalName("RET_SWORD_TRAINING_COMBAT_RANK_NOT_CHANGE")]
		RetSwordTrainingCombatRankNotChange,
		// Token: 0x040040E7 RID: 16615
		[OriginalName("RET_SWORD_TRAINING_DIRECT_BATTLE_DISABLE")]
		RetSwordTrainingDirectBattleDisable,
		// Token: 0x040040E8 RID: 16616
		[OriginalName("RET_FIGHT_FEST_PHASE_NOT_MATCH")]
		RetFightFestPhaseNotMatch = 6351,
		// Token: 0x040040E9 RID: 16617
		[OriginalName("RET_FIGHT_FEST_SCORE_RACE_ALREADY_FINISH")]
		RetFightFestScoreRaceAlreadyFinish,
		// Token: 0x040040EA RID: 16618
		[OriginalName("RET_FIGHT_FEST_CHALLENGE_LOCKED")]
		RetFightFestChallengeLocked,
		// Token: 0x040040EB RID: 16619
		[OriginalName("RET_FIGHT_FEST_COACH_SKILL_LOCKED")]
		RetFightFestCoachSkillLocked,
		// Token: 0x040040EC RID: 16620
		[OriginalName("RET_FIGHT_FEST_COACH_SKILL_EQUIP_TYPE_EXISTED")]
		RetFightFestCoachSkillEquipTypeExisted,
		// Token: 0x040040ED RID: 16621
		[OriginalName("RET_FIGHT_FEST_SCORE_RACE_MISSION_DOIND")]
		RetFightFestScoreRaceMissionDoind,
		// Token: 0x040040EE RID: 16622
		[OriginalName("RET_FIGHT_FEST_COACH_SKILL_NO_EQUIP")]
		RetFightFestCoachSkillNoEquip,
		// Token: 0x040040EF RID: 16623
		[OriginalName("RET_PET_NOT_EXIST")]
		RetPetNotExist = 6401,
		// Token: 0x040040F0 RID: 16624
		[OriginalName("RET_PET_ALREADY_SUMMONED")]
		RetPetAlreadySummoned,
		// Token: 0x040040F1 RID: 16625
		[OriginalName("RET_PET_NOT_SUMMONED")]
		RetPetNotSummoned,
		// Token: 0x040040F2 RID: 16626
		[OriginalName("RET_MUSIC_RHYTHM_LEVEL_TIME_TOO_SHORT")]
		RetMusicRhythmLevelTimeTooShort = 6451,
		// Token: 0x040040F3 RID: 16627
		[OriginalName("RET_MUSIC_RHYTHM_NOT_IN_LEVEL")]
		RetMusicRhythmNotInLevel,
		// Token: 0x040040F4 RID: 16628
		[OriginalName("RET_MUSIC_RHYTHM_PRE_DIFFICULTY_NOT_PASS")]
		RetMusicRhythmPreDifficultyNotPass,
		// Token: 0x040040F5 RID: 16629
		[OriginalName("RET_MUSIC_RHYTHM_SONG_LIMITED")]
		RetMusicRhythmSongLimited,
		// Token: 0x040040F6 RID: 16630
		[OriginalName("RET_MUSIC_RHYTHM_SONG_LOCKED")]
		RetMusicRhythmSongLocked,
		// Token: 0x040040F7 RID: 16631
		[OriginalName("RET_MUSIC_RHYTHM_TRACK_LOCKED")]
		RetMusicRhythmTrackLocked,
		// Token: 0x040040F8 RID: 16632
		[OriginalName("RET_MUSIC_RHYTHM_LEVEL_NOT_UNLOCK")]
		RetMusicRhythmLevelNotUnlock
	}
}
