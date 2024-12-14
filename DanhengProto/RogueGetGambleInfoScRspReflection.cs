using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E96 RID: 3734
	public static class RogueGetGambleInfoScRspReflection
	{
		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x001C16BA File Offset: 0x001BF8BA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGetGambleInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004440 RID: 17472
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUdldEdhbWJsZUluZm9TY1JzcC5wcm90bxoVUm9ndWVHYW1ibGVJ" + "bmZvLnByb3RvIlEKF1JvZ3VlR2V0R2FtYmxlSW5mb1NjUnNwEiUKC2dhbWJs" + "ZV9pbmZvGAogASgLMhAuUm9ndWVHYW1ibGVJbmZvEg8KB3JldGNvZGUYDSAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueGambleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGetGambleInfoScRsp), RogueGetGambleInfoScRsp.Parser, new string[]
			{
				"GambleInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
