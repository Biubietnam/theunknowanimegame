using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001190 RID: 4496
	public static class StartAetherDivideSceneBattleCsReqReflection
	{
		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600C8B8 RID: 51384 RVA: 0x0021A754 File Offset: 0x00218954
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005101 RID: 20737
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlQ3NSZXEucHJvdG8aHUFz",
			"c2lzdE1vbnN0ZXJFbnRpdHlJbmZvLnByb3RvItQBCiFTdGFydEFldGhlckRp",
			"dmlkZVNjZW5lQmF0dGxlQ3NSZXESEwoLc2tpbGxfaW5kZXgYDiABKA0SPAoa",
			"YXNzaXN0X21vbnN0ZXJfZW50aXR5X2luZm8YByADKAsyGC5Bc3Npc3RNb25z",
			"dGVyRW50aXR5SW5mbxIdChVhdHRhY2tlZF9ieV9lbnRpdHlfaWQYCCABKA0S",
			"JQodYXNzaXN0X21vbnN0ZXJfZW50aXR5X2lkX2xpc3QYBCADKA0SFgoOY2Fz",
			"dF9lbnRpdHlfaWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AssistMonsterEntityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideSceneBattleCsReq), StartAetherDivideSceneBattleCsReq.Parser, new string[]
			{
				"SkillIndex",
				"AssistMonsterEntityInfo",
				"AttackedByEntityId",
				"AssistMonsterEntityIdList",
				"CastEntityId"
			}, null, null, null, null)
		}));
	}
}
