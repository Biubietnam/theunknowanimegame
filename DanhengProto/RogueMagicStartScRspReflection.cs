using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F20 RID: 3872
	public static class RogueMagicStartScRspReflection
	{
		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x001D1029 File Offset: 0x001CF229
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicStartScRspReflection.descriptor;
			}
		}

		// Token: 0x0400466D RID: 18029
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljU3RhcnRTY1JzcC5wcm90bxocUm9ndWVNYWdpY0N1clNj",
			"ZW5lSW5mby5wcm90bxoXUm9ndWVNYWdpY0N1ckluZm8ucHJvdG8ilgEKFFJv",
			"Z3VlTWFnaWNTdGFydFNjUnNwEg8KB3JldGNvZGUYCyABKA0SOwoacm9ndWVf",
			"dG91cm5fY3VyX3NjZW5lX2luZm8YAiABKAsyFy5Sb2d1ZU1hZ2ljQ3VyU2Nl",
			"bmVJbmZvEjAKFHJvZ3VlX3RvdXJuX2N1cl9pbmZvGAkgASgLMhIuUm9ndWVN",
			"YWdpY0N1ckluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicCurSceneInfoReflection.Descriptor,
			RogueMagicCurInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStartScRsp), RogueMagicStartScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo",
				"RogueTournCurInfo"
			}, null, null, null, null)
		}));
	}
}
