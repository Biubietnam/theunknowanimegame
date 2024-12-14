using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001076 RID: 4214
	public static class SceneInfoReflection
	{
		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x001F8B24 File Offset: 0x001F6D24
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneInfoReflection.descriptor;
			}
		}

		// Token: 0x04004C18 RID: 19480
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9TY2VuZUluZm8ucHJvdG8aGlNjZW5lRW50aXR5R3JvdXBJbmZvLnByb3Rv",
			"GhRDdXN0b21TYXZlRGF0YS5wcm90bxoURW50aXR5QnVmZkluZm8ucHJvdG8a",
			"EUpCRU9GTUhDT0lDLnByb3RvGg5CdWZmSW5mby5wcm90bxoeTWlzc2lvblN0",
			"YXR1c0J5U2NlbmVJbmZvLnByb3RvGhVTY2VuZUVudGl0eUluZm8ucHJvdG8a",
			"FVNjZW5lR3JvdXBTdGF0ZS5wcm90byLHBgoJU2NlbmVJbmZvEhoKEmNsaWVu",
			"dF9wb3NfdmVyc2lvbhgMIAEoDRIcChRsaWdodGVuX3NlY3Rpb25fbGlzdBgF",
			"IAMoDRIxChFlbnRpdHlfZ3JvdXBfbGlzdBixAiADKAsyFS5TY2VuZUVudGl0",
			"eUdyb3VwSW5mbxIbChJnYW1lX3N0b3J5X2xpbmVfaWQY1Q0gASgNEhAKCGZs",
			"b29yX2lkGAMgASgNEicKFHNjZW5lX2J1ZmZfaW5mb19saXN0GAsgAygLMgku",
			"QnVmZkluZm8SLgoVZW50aXR5X2J1ZmZfaW5mb19saXN0GAEgAygLMg8uRW50",
			"aXR5QnVmZkluZm8SEAoIZW50cnlfaWQYCCABKA0SNgoSc2NlbmVfbWlzc2lv",
			"bl9pbmZvGJUFIAEoCzIZLk1pc3Npb25TdGF0dXNCeVNjZW5lSW5mbxIrChBn",
			"cm91cF9zdGF0ZV9saXN0GLAEIAMoCzIQLlNjZW5lR3JvdXBTdGF0ZRI4ChBm",
			"bG9vcl9zYXZlZF9kYXRhGBggAygLMh4uU2NlbmVJbmZvLkZsb29yU2F2ZWRE",
			"YXRhRW50cnkSGAoQbGVhZGVyX2VudGl0eV9pZBgHIAEoDRIlCgtlbnRpdHlf",
			"bGlzdBgCIAMoCzIQLlNjZW5lRW50aXR5SW5mbxIVCgxkaW1lbnNpb25faWQY",
			"nQMgASgNEhUKDWdyb3VwX2lkX2xpc3QYCiADKA0SFgoOZ2FtZV9tb2RlX3R5",
			"cGUYBCABKA0SEwoKY29udGVudF9pZBjkCiABKA0SKQoQY3VzdG9tX2RhdGFf",
			"bGlzdBgPIAMoCzIPLkN1c3RvbVNhdmVEYXRhEjAKC0xGRlBQQlBOT0FDGA0g",
			"AygLMhsuU2NlbmVJbmZvLkxGRlBQQlBOT0FDRW50cnkSEAoId29ybGRfaWQY",
			"DiABKA0SEAoIcGxhbmVfaWQYCSABKA0aNQoTRmxvb3JTYXZlZERhdGFFbnRy",
			"eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBGkAKEExGRlBQQlBO",
			"T0FDRW50cnkSCwoDa2V5GAEgASgNEhsKBXZhbHVlGAIgASgLMgwuSkJFT0ZN",
			"SENPSUM6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			SceneEntityGroupInfoReflection.Descriptor,
			CustomSaveDataReflection.Descriptor,
			EntityBuffInfoReflection.Descriptor,
			JBEOFMHCOICReflection.Descriptor,
			BuffInfoReflection.Descriptor,
			MissionStatusBySceneInfoReflection.Descriptor,
			SceneEntityInfoReflection.Descriptor,
			SceneGroupStateReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneInfo), SceneInfo.Parser, new string[]
			{
				"ClientPosVersion",
				"LightenSectionList",
				"EntityGroupList",
				"GameStoryLineId",
				"FloorId",
				"SceneBuffInfoList",
				"EntityBuffInfoList",
				"EntryId",
				"SceneMissionInfo",
				"GroupStateList",
				"FloorSavedData",
				"LeaderEntityId",
				"EntityList",
				"DimensionId",
				"GroupIdList",
				"GameModeType",
				"ContentId",
				"CustomDataList",
				"LFFPPBPNOAC",
				"WorldId",
				"PlaneId"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
