using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045A RID: 1114
	public static class EnterRogueMapRoomScRspReflection
	{
		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x000885E1 File Offset: 0x000867E1
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterRogueMapRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x040013BE RID: 5054
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxFbnRlclJvZ3VlTWFwUm9vbVNjUnNwLnByb3RvGhBMaW5ldXBJbmZvLnBy",
			"b3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aD1NjZW5lSW5mby5wcm90",
			"byKgAQoWRW50ZXJSb2d1ZU1hcFJvb21TY1JzcBIZCgVzY2VuZRgCIAEoCzIK",
			"LlNjZW5lSW5mbxIoCgtyb3RhdGVfaW5mbxgBIAEoCzITLlJvZ3VlTWFwUm90",
			"YXRlSW5mbxIPCgdyZXRjb2RlGAUgASgNEhsKBmxpbmV1cBgDIAEoCzILLkxp",
			"bmV1cEluZm8SEwoLY3VyX3NpdGVfaWQYBCABKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueMapRoomScRsp), EnterRogueMapRoomScRsp.Parser, new string[]
			{
				"Scene",
				"RotateInfo",
				"Retcode",
				"Lineup",
				"CurSiteId"
			}, null, null, null, null)
		}));
	}
}
