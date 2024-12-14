using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B4 RID: 4276
	public static class SelectRogueCommonDialogueOptionScRspReflection
	{
		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600BEAE RID: 48814 RVA: 0x002017C9 File Offset: 0x001FF9C9
		public static FileDescriptor Descriptor
		{
			get
			{
				return SelectRogueCommonDialogueOptionScRspReflection.descriptor;
			}
		}

		// Token: 0x04004D72 RID: 19826
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipTZWxlY3RSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uU2NSc3AucHJvdG8a",
			"IVJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhSW5mby5wcm90byLQAQokU2VsZWN0",
			"Um9ndWVDb21tb25EaWFsb2d1ZU9wdGlvblNjUnNwEg8KB3JldGNvZGUYASAB",
			"KA0SEQoJb3B0aW9uX2lkGA4gASgNEhwKFGVmZmVjdF9ldmVudF9pZF9saXN0",
			"GAsgAygNEhcKD2V2ZW50X3VuaXF1ZV9pZBgDIAEoDRIYChBldmVudF9oYXNf",
			"ZWZmZWN0GAcgASgIEjMKDWRpYWxvZ3VlX2RhdGEYCiABKAsyHC5Sb2d1ZUNv",
			"bW1vbkRpYWxvZ3VlRGF0YUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonDialogueDataInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SelectRogueCommonDialogueOptionScRsp), SelectRogueCommonDialogueOptionScRsp.Parser, new string[]
			{
				"Retcode",
				"OptionId",
				"EffectEventIdList",
				"EventUniqueId",
				"EventHasEffect",
				"DialogueData"
			}, null, null, null, null)
		}));
	}
}
