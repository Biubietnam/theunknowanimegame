using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200069E RID: 1694
	public static class GetFeverTimeActivityDataScRspReflection
	{
		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x000CDF96 File Offset: 0x000CC196
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFeverTimeActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E0A RID: 7690
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNHZXRGZXZlclRpbWVBY3Rpdml0eURhdGFTY1JzcC5wcm90bxobRmV2ZXJU",
			"aW1lQWN0aXZpdHlEYXRhLnByb3RvIl0KHUdldEZldmVyVGltZUFjdGl2aXR5",
			"RGF0YVNjUnNwEg8KB3JldGNvZGUYDSABKA0SKwoLS0VDS0dMSkxJTE0YAiAD",
			"KAsyFi5GZXZlclRpbWVBY3Rpdml0eURhdGFCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			FeverTimeActivityDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFeverTimeActivityDataScRsp), GetFeverTimeActivityDataScRsp.Parser, new string[]
			{
				"Retcode",
				"KECKGLJLILM"
			}, null, null, null, null)
		}));
	}
}
