using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA4 RID: 4004
	public static class RogueTournEnterLayerScRspReflection
	{
		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600B26D RID: 45677 RVA: 0x001DF5C9 File Offset: 0x001DD7C9
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterLayerScRspReflection.descriptor;
			}
		}

		// Token: 0x04004881 RID: 18561
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Sb2d1ZVRvdXJuRW50ZXJMYXllclNjUnNwLnByb3RvGhxSb2d1ZVRvdXJu",
			"Q3VyU2NlbmVJbmZvLnByb3RvImkKGVJvZ3VlVG91cm5FbnRlckxheWVyU2NS",
			"c3ASDwoHcmV0Y29kZRgJIAEoDRI7Chpyb2d1ZV90b3Vybl9jdXJfc2NlbmVf",
			"aW5mbxgHIAEoCzIXLlJvZ3VlVG91cm5DdXJTY2VuZUluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterLayerScRsp), RogueTournEnterLayerScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
