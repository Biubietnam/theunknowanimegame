using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000832 RID: 2098
	public static class GetTreasureDungeonActivityDataScRspReflection
	{
		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06005D66 RID: 23910 RVA: 0x000F7CC6 File Offset: 0x000F5EC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTreasureDungeonActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002410 RID: 9232
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilHZXRUcmVhc3VyZUR1bmdlb25BY3Rpdml0eURhdGFTY1JzcC5wcm90bxoh",
			"VHJlYXN1cmVEdW5nZW9uQWN0aXZpdHlEYXRhLnByb3RvImkKI0dldFRyZWFz",
			"dXJlRHVuZ2VvbkFjdGl2aXR5RGF0YVNjUnNwEg8KB3JldGNvZGUYDSABKA0S",
			"MQoLSkZQSVBJQk9JRkMYBSADKAsyHC5UcmVhc3VyZUR1bmdlb25BY3Rpdml0",
			"eURhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			TreasureDungeonActivityDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTreasureDungeonActivityDataScRsp), GetTreasureDungeonActivityDataScRsp.Parser, new string[]
			{
				"Retcode",
				"JFPIPIBOIFC"
			}, null, null, null, null)
		}));
	}
}
