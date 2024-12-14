using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000062 RID: 98
	public static class AetherDivideSpiritExpUpScRspReflection
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000C49C File Offset: 0x0000A69C
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritExpUpScRspReflection.descriptor;
			}
		}

		// Token: 0x04000182 RID: 386
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcFNjUnNwLnByb3RvGhxBZXRoZXJE",
			"aXZpZGVTcGlyaXRJbmZvLnByb3RvInIKHEFldGhlckRpdmlkZVNwaXJpdEV4",
			"cFVwU2NSc3ASLAoLYWV0aGVyX2luZm8YAyABKAsyFy5BZXRoZXJEaXZpZGVT",
			"cGlyaXRJbmZvEg8KB3JldGNvZGUYBiABKA0SEwoLTlBHT01MRkdCSk0YCCAB",
			"KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherDivideSpiritInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSpiritExpUpScRsp), AetherDivideSpiritExpUpScRsp.Parser, new string[]
			{
				"AetherInfo",
				"Retcode",
				"NPGOMLFGBJM"
			}, null, null, null, null)
		}));
	}
}
