using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200109C RID: 4252
	public static class SecurityReportScRspReflection
	{
		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600BD8E RID: 48526 RVA: 0x001FECA2 File Offset: 0x001FCEA2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SecurityReportScRspReflection.descriptor;
			}
		}

		// Token: 0x04004D12 RID: 19730
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTZWN1cml0eVJlcG9ydFNjUnNwLnByb3RvIiYKE1NlY3VyaXR5UmVwb3J0" + "U2NSc3ASDwoHcmV0Y29kZRgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SecurityReportScRsp), SecurityReportScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
