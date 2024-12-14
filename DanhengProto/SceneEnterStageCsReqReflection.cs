using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200105A RID: 4186
	public static class SceneEnterStageCsReqReflection
	{
		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x001F51F5 File Offset: 0x001F33F5
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEnterStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004B9C RID: 19356
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpTY2VuZUVudGVyU3RhZ2VDc1JlcS5wcm90bxoSUmViYXR0bGVUeXBlLnBy",
			"b3RvImMKFFNjZW5lRW50ZXJTdGFnZUNzUmVxEhMKC0dKQk9PRkhCRU9QGA0g",
			"ASgIEiQKDXJlYmF0dGxlX3R5cGUYCCABKA4yDS5SZWJhdHRsZVR5cGUSEAoI",
			"ZXZlbnRfaWQYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RebattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEnterStageCsReq), SceneEnterStageCsReq.Parser, new string[]
			{
				"GJBOOFHBEOP",
				"RebattleType",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
