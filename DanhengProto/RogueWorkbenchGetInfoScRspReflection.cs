using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001034 RID: 4148
	public static class RogueWorkbenchGetInfoScRspReflection
	{
		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x001EF5AA File Offset: 0x001ED7AA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchGetInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004AC5 RID: 19141
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBSb2d1ZVdvcmtiZW5jaEdldEluZm9TY1JzcC5wcm90bxoXV29ya2JlbmNo",
			"RnVuY0luZm8ucHJvdG8iugEKGlJvZ3VlV29ya2JlbmNoR2V0SW5mb1NjUnNw",
			"EkMKDWZ1bmNfaW5mb19tYXAYASADKAsyLC5Sb2d1ZVdvcmtiZW5jaEdldElu",
			"Zm9TY1JzcC5GdW5jSW5mb01hcEVudHJ5Eg8KB3JldGNvZGUYDyABKA0aRgoQ",
			"RnVuY0luZm9NYXBFbnRyeRILCgNrZXkYASABKA0SIQoFdmFsdWUYAiABKAsy",
			"Ei5Xb3JrYmVuY2hGdW5jSW5mbzoCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WorkbenchFuncInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchGetInfoScRsp), RogueWorkbenchGetInfoScRsp.Parser, new string[]
			{
				"FuncInfoMap",
				"Retcode"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
