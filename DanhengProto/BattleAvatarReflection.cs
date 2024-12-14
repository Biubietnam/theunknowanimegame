using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D8 RID: 216
	public static class BattleAvatarReflection
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0001C3B2 File Offset: 0x0001A5B2
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleAvatarReflection.descriptor;
			}
		}

		// Token: 0x040003EB RID: 1003
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJCYXR0bGVBdmF0YXIucHJvdG8aFUF2YXRhclNraWxsVHJlZS5wcm90bxoR",
			"Q0RDUEJJQVBNQk0ucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aD1NwQmFySW5m",
			"by5wcm90bxoVQmF0dGxlRXF1aXBtZW50LnByb3RvGhFCYXR0bGVSZWxpYy5w",
			"cm90byL6AgoMQmF0dGxlQXZhdGFyEiAKC2F2YXRhcl90eXBlGAEgASgOMgsu",
			"QXZhdGFyVHlwZRIKCgJpZBgCIAEoDRINCgVsZXZlbBgDIAEoDRIMCgRyYW5r",
			"GAQgASgNEg0KBWluZGV4GAUgASgNEigKDnNraWxsdHJlZV9saXN0GAYgAygL",
			"MhAuQXZhdGFyU2tpbGxUcmVlEigKDmVxdWlwbWVudF9saXN0GAcgAygLMhAu",
			"QmF0dGxlRXF1aXBtZW50EgoKAmhwGAggASgNEhEKCXByb21vdGlvbhgKIAEo",
			"DRIgCgpyZWxpY19saXN0GAsgAygLMgwuQmF0dGxlUmVsaWMSEwoLd29ybGRf",
			"bGV2ZWwYDCABKA0SEgoKYXNzaXN0X3VpZBgNIAEoDRIhCgtNQlBOSUNQSU1I",
			"SBgPIAEoCzIMLkNEQ1BCSUFQTUJNEhoKBnNwX2JhchgQIAEoCzIKLlNwQmFy",
			"SW5mbxITCgtNS0pLTU1JT0NIQhgRIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AvatarSkillTreeReflection.Descriptor,
			CDCPBIAPMBMReflection.Descriptor,
			AvatarTypeReflection.Descriptor,
			SpBarInfoReflection.Descriptor,
			BattleEquipmentReflection.Descriptor,
			BattleRelicReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleAvatar), BattleAvatar.Parser, new string[]
			{
				"AvatarType",
				"Id",
				"Level",
				"Rank",
				"Index",
				"SkilltreeList",
				"EquipmentList",
				"Hp",
				"Promotion",
				"RelicList",
				"WorldLevel",
				"AssistUid",
				"MBPNICPIMHH",
				"SpBar",
				"MKJKMMIOCHB"
			}, null, null, null, null)
		}));
	}
}
