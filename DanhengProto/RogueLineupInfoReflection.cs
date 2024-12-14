using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA8 RID: 3752
	public static class RogueLineupInfoReflection
	{
		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600A7A6 RID: 42918 RVA: 0x001C378D File Offset: 0x001C198D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueLineupInfoReflection.descriptor;
			}
		}

		// Token: 0x04004486 RID: 17542
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZUxpbmV1cEluZm8ucHJvdG8aFVJvZ3VlUmV2aXZlSW5mby5wcm90",
			"byKIAQoPUm9ndWVMaW5ldXBJbmZvEiUKC3Jldml2ZV9pbmZvGA8gASgLMhAu",
			"Um9ndWVSZXZpdmVJbmZvEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYCSADKA0S",
			"HAoUdHJpYWxfYXZhdGFyX2lkX2xpc3QYBSADKA0SEwoLR0dIQ0JQQkVGRkoY",
			"DiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueReviveInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueLineupInfo), RogueLineupInfo.Parser, new string[]
			{
				"ReviveInfo",
				"BaseAvatarIdList",
				"TrialAvatarIdList",
				"GGHCBPBEFFJ"
			}, null, null, null, null)
		}));
	}
}
