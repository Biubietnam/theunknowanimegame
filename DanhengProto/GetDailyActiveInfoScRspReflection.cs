using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000680 RID: 1664
	public static class GetDailyActiveInfoScRspReflection
	{
		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06004A8D RID: 19085 RVA: 0x000CABD2 File Offset: 0x000C8DD2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetDailyActiveInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D8E RID: 7566
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXREYWlseUFjdGl2ZUluZm9TY1JzcC5wcm90bxoXRGFpbHlBY3Rpdml0",
			"eUluZm8ucHJvdG8inwEKF0dldERhaWx5QWN0aXZlSW5mb1NjUnNwEhoKEmRh",
			"aWx5X2FjdGl2ZV9wb2ludBgGIAEoDRIiChpkYWlseV9hY3RpdmVfcXVlc3Rf",
			"aWRfbGlzdBgIIAMoDRIPCgdyZXRjb2RlGAcgASgNEjMKF2RhaWx5X2FjdGl2",
			"ZV9sZXZlbF9saXN0GAEgAygLMhIuRGFpbHlBY3Rpdml0eUluZm9CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			DailyActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetDailyActiveInfoScRsp), GetDailyActiveInfoScRsp.Parser, new string[]
			{
				"DailyActivePoint",
				"DailyActiveQuestIdList",
				"Retcode",
				"DailyActiveLevelList"
			}, null, null, null, null)
		}));
	}
}
