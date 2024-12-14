using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001406 RID: 5126
	public static class UpgradeAreaStatScRspReflection
	{
		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x0025FCEC File Offset: 0x0025DEEC
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaStatScRspReflection.descriptor;
			}
		}

		// Token: 0x04005ACD RID: 23245
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpVcGdyYWRlQXJlYVN0YXRTY1JzcC5wcm90bxoOU3RhdFR5cGUucHJvdG8i",
			"ZwoUVXBncmFkZUFyZWFTdGF0U2NSc3ASHgoLSUZKRUJPSUVHRkcYCCABKA4y",
			"CS5TdGF0VHlwZRIPCgdyZXRjb2RlGAwgASgNEg8KB2FyZWFfaWQYCSABKA0S",
			"DQoFbGV2ZWwYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			StatTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaStatScRsp), UpgradeAreaStatScRsp.Parser, new string[]
			{
				"IFJEBOIEGFG",
				"Retcode",
				"AreaId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
