using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E6 RID: 2022
	public static class GetSceneMapInfoScRspReflection
	{
		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x000F0A10 File Offset: 0x000EEC10
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSceneMapInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002309 RID: 8969
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRTY2VuZU1hcEluZm9TY1JzcC5wcm90bxoSU2NlbmVNYXBJbmZvLnBy",
			"b3RvImMKFEdldFNjZW5lTWFwSW5mb1NjUnNwEiUKDnNjZW5lX21hcF9pbmZv",
			"GAggAygLMg0uU2NlbmVNYXBJbmZvEhMKC1BORlBCSUNHRFBDGAUgASgIEg8K",
			"B3JldGNvZGUYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneMapInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSceneMapInfoScRsp), GetSceneMapInfoScRsp.Parser, new string[]
			{
				"SceneMapInfo",
				"PNFPBICGDPC",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
