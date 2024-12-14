using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8E RID: 3982
	public static class RogueTournCurInfoReflection
	{
		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600B177 RID: 45431 RVA: 0x001DD28E File Offset: 0x001DB48E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournCurInfoReflection.descriptor;
			}
		}

		// Token: 0x04004839 RID: 18489
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdSb2d1ZVRvdXJuQ3VySW5mby5wcm90bxobUm9ndWVUb3VybkN1ckdhbWVJ",
			"bmZvLnByb3RvGhtSb2d1ZVRvdXJuQ3VyQXJlYUluZm8ucHJvdG8iigEKEVJv",
			"Z3VlVG91cm5DdXJJbmZvEjkKGXJvZ3VlX3RvdXJuX2N1cl9hcmVhX2luZm8Y",
			"DCABKAsyFi5Sb2d1ZVRvdXJuQ3VyQXJlYUluZm8SOgoZcm9ndWVfdG91cm5f",
			"Y3VyX2dhbWVfaW5mbxioAiABKAsyFi5Sb2d1ZVRvdXJuQ3VyR2FtZUluZm9C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournCurGameInfoReflection.Descriptor,
			RogueTournCurAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournCurInfo), RogueTournCurInfo.Parser, new string[]
			{
				"RogueTournCurAreaInfo",
				"RogueTournCurGameInfo"
			}, null, null, null, null)
		}));
	}
}
