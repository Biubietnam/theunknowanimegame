using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B6 RID: 182
	public static class AssistSimpleInfoReflection
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000160D0 File Offset: 0x000142D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return AssistSimpleInfoReflection.descriptor;
			}
		}

		// Token: 0x040002EF RID: 751
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBc3Npc3RTaW1wbGVJbmZvLnByb3RvIloKEEFzc2lzdFNpbXBsZUluZm8S" + "EQoJYXZhdGFyX2lkGAggASgNEgsKA1BvcxgKIAEoDRIXCg9kcmVzc2VkX3Nr" + "aW5faWQYAiABKA0SDQoFbGV2ZWwYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AssistSimpleInfo), AssistSimpleInfo.Parser, new string[]
			{
				"AvatarId",
				"Pos",
				"DressedSkinId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
