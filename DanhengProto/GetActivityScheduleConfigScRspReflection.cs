using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F8 RID: 1528
	public static class GetActivityScheduleConfigScRspReflection
	{
		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x000BC0E2 File Offset: 0x000BA2E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetActivityScheduleConfigScRspReflection.descriptor;
			}
		}

		// Token: 0x04001B70 RID: 7024
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHZXRBY3Rpdml0eVNjaGVkdWxlQ29uZmlnU2NSc3AucHJvdG8aGkFjdGl2",
			"aXR5U2NoZWR1bGVEYXRhLnByb3RvIl8KHkdldEFjdGl2aXR5U2NoZWR1bGVD",
			"b25maWdTY1JzcBIPCgdyZXRjb2RlGAMgASgNEiwKDXNjaGVkdWxlX2RhdGEY",
			"AiADKAsyFS5BY3Rpdml0eVNjaGVkdWxlRGF0YUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ActivityScheduleDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityScheduleConfigScRsp), GetActivityScheduleConfigScRsp.Parser, new string[]
			{
				"Retcode",
				"ScheduleData"
			}, null, null, null, null)
		}));
	}
}
