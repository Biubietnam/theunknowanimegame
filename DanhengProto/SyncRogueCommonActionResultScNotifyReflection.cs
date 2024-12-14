using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001282 RID: 4738
	public static class SyncRogueCommonActionResultScNotifyReflection
	{
		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600D36B RID: 54123 RVA: 0x0023496A File Offset: 0x00232B6A
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonActionResultScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054A4 RID: 21668
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilTeW5jUm9ndWVDb21tb25BY3Rpb25SZXN1bHRTY05vdGlmeS5wcm90bxoo",
			"Um9ndWVDb21tb25BY3Rpb25SZXN1bHREaXNwbGF5VHlwZS5wcm90bxodUm9n",
			"dWVDb21tb25BY3Rpb25SZXN1bHQucHJvdG8irgEKI1N5bmNSb2d1ZUNvbW1v",
			"bkFjdGlvblJlc3VsdFNjTm90aWZ5EjkKDGRpc3BsYXlfdHlwZRgJIAEoDjIj",
			"LlJvZ3VlQ29tbW9uQWN0aW9uUmVzdWx0RGlzcGxheVR5cGUSNAoSYWN0aW9u",
			"X3Jlc3VsdF9saXN0GA0gAygLMhguUm9ndWVDb21tb25BY3Rpb25SZXN1bHQS",
			"FgoOcm9ndWVfc3ViX21vZGUYCCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonActionResultDisplayTypeReflection.Descriptor,
			RogueCommonActionResultReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonActionResultScNotify), SyncRogueCommonActionResultScNotify.Parser, new string[]
			{
				"DisplayType",
				"ActionResultList",
				"RogueSubMode"
			}, null, null, null, null)
		}));
	}
}
