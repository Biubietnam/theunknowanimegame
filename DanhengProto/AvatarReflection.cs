using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BA RID: 186
	public static class AvatarReflection
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0001690D File Offset: 0x00014B0D
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarReflection.descriptor;
			}
		}

		// Token: 0x04000301 RID: 769
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CgxBdmF0YXIucHJvdG8aEEVxdWlwUmVsaWMucHJvdG8aFUF2YXRhclNraWxs",
			"VHJlZS5wcm90byK+AgoGQXZhdGFyEgsKA2V4cBgBIAEoDRIoCg5za2lsbHRy",
			"ZWVfbGlzdBgDIAMoCzIQLkF2YXRhclNraWxsVHJlZRIXCg9kcmVzc2VkX3Nr",
			"aW5faWQYAiABKA0SDAoEcmFuaxgJIAEoDRINCgVsZXZlbBgFIAEoDRIRCglw",
			"cm9tb3Rpb24YCCABKA0SJwofaGFzX3Rha2VuX3Byb21vdGlvbl9yZXdhcmRf",
			"bGlzdBgLIAMoDRIbChNlcXVpcG1lbnRfdW5pcXVlX2lkGA8gASgNEhYKDmJh",
			"c2VfYXZhdGFyX2lkGAogASgNEhwKFGZpcnN0X21ldF90aW1lX3N0YW1wGA0g",
			"ASgEEhEKCWlzX21hcmtlZBgHIAEoCBIlChBlcXVpcF9yZWxpY19saXN0GAwg",
			"AygLMgsuRXF1aXBSZWxpY0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EquipRelicReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Avatar), Avatar.Parser, new string[]
			{
				"Exp",
				"SkilltreeList",
				"DressedSkinId",
				"Rank",
				"Level",
				"Promotion",
				"HasTakenPromotionRewardList",
				"EquipmentUniqueId",
				"BaseAvatarId",
				"FirstMetTimeStamp",
				"IsMarked",
				"EquipRelicList"
			}, null, null, null, null)
		}));
	}
}
