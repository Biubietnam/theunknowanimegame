using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E48 RID: 3656
	public static class RogueCommonDialogueOptionDisplayInfoReflection
	{
		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600A31F RID: 41759 RVA: 0x001B6D62 File Offset: 0x001B4F62
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionDisplayInfoReflection.descriptor;
			}
		}

		// Token: 0x040042D0 RID: 17104
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uRGlzcGxheUluZm8ucHJvdG8i" + "XgokUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkRpc3BsYXlJbmZvEhkKEWRp" + "c3BsYXlfaW50X3ZhbHVlGA0gASgFEhsKE2Rpc3BsYXlfZmxvYXRfdmFsdWUY" + "BiABKAJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDialogueOptionDisplayInfo), RogueCommonDialogueOptionDisplayInfo.Parser, new string[]
			{
				"DisplayIntValue",
				"DisplayFloatValue"
			}, null, null, null, null)
		}));
	}
}
