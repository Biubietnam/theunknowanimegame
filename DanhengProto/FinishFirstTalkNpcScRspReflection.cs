using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000580 RID: 1408
	public static class FinishFirstTalkNpcScRspReflection
	{
		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x000ABB56 File Offset: 0x000A9D56
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkNpcScRspReflection.descriptor;
			}
		}

		// Token: 0x0400190E RID: 6414
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1GaW5pc2hGaXJzdFRhbGtOcGNTY1JzcC5wcm90byI6ChdGaW5pc2hGaXJz" + "dFRhbGtOcGNTY1JzcBIOCgZucGNfaWQYBCABKA0SDwoHcmV0Y29kZRgFIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkNpcScRsp), FinishFirstTalkNpcScRsp.Parser, new string[]
			{
				"NpcId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
