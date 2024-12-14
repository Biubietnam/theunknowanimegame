using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC6 RID: 3782
	public static class RogueMagicEnterLayerScRspReflection
	{
		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600A90B RID: 43275 RVA: 0x001C73C8 File Offset: 0x001C55C8
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterLayerScRspReflection.descriptor;
			}
		}

		// Token: 0x04004507 RID: 17671
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Sb2d1ZU1hZ2ljRW50ZXJMYXllclNjUnNwLnByb3RvGhxSb2d1ZU1hZ2lj",
			"Q3VyU2NlbmVJbmZvLnByb3RvImkKGVJvZ3VlTWFnaWNFbnRlckxheWVyU2NS",
			"c3ASDwoHcmV0Y29kZRgPIAEoDRI7Chpyb2d1ZV90b3Vybl9jdXJfc2NlbmVf",
			"aW5mbxgEIAEoCzIXLlJvZ3VlTWFnaWNDdXJTY2VuZUluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterLayerScRsp), RogueMagicEnterLayerScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
