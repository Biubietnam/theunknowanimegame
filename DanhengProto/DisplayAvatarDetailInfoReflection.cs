using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AC RID: 940
	public static class DisplayAvatarDetailInfoReflection
	{
		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x00074119 File Offset: 0x00072319
		public static FileDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarDetailInfoReflection.descriptor;
			}
		}

		// Token: 0x040010D7 RID: 4311
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1EaXNwbGF5QXZhdGFyRGV0YWlsSW5mby5wcm90bxoWRGlzcGxheVJlbGlj",
			"SW5mby5wcm90bxoaRGlzcGxheUVxdWlwbWVudEluZm8ucHJvdG8aFUF2YXRh",
			"clNraWxsVHJlZS5wcm90byKIAgoXRGlzcGxheUF2YXRhckRldGFpbEluZm8S",
			"DAoEcmFuaxgIIAEoDRILCgNFeHAYDSABKA0SFwoPZHJlc3NlZF9za2luX2lk",
			"GAwgASgNEhEKCWF2YXRhcl9pZBgCIAEoDRIkCglSZWxpY0xpc3QYDiADKAsy",
			"ES5EaXNwbGF5UmVsaWNJbmZvEgsKA1BvcxgBIAEoDRInCg1Ta2lsbHRyZWVM",
			"aXN0GA8gAygLMhAuQXZhdGFyU2tpbGxUcmVlEhEKCXByb21vdGlvbhgKIAEo",
			"DRINCgVsZXZlbBgJIAEoDRIoCglFcXVpcG1lbnQYAyABKAsyFS5EaXNwbGF5",
			"RXF1aXBtZW50SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			DisplayRelicInfoReflection.Descriptor,
			DisplayEquipmentInfoReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarDetailInfo), DisplayAvatarDetailInfo.Parser, new string[]
			{
				"Rank",
				"Exp",
				"DressedSkinId",
				"AvatarId",
				"RelicList",
				"Pos",
				"SkilltreeList",
				"Promotion",
				"Level",
				"Equipment"
			}, null, null, null, null)
		}));
	}
}
