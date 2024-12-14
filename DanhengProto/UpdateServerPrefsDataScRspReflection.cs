using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FA RID: 5114
	public static class UpdateServerPrefsDataScRspReflection
	{
		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x0600E40C RID: 58380 RVA: 0x0025E66D File Offset: 0x0025C86D
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateServerPrefsDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04005A9B RID: 23195
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90byJGChpVcGRhdGVT" + "ZXJ2ZXJQcmVmc0RhdGFTY1JzcBIXCg9zZXJ2ZXJfcHJlZnNfaWQYCSABKA0S" + "DwoHcmV0Y29kZRgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateServerPrefsDataScRsp), UpdateServerPrefsDataScRsp.Parser, new string[]
			{
				"ServerPrefsId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
