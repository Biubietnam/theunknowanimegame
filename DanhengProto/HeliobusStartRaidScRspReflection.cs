using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008DA RID: 2266
	public static class HeliobusStartRaidScRspReflection
	{
		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x0010E753 File Offset: 0x0010C953
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusStartRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x040026E9 RID: 9961
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxIZWxpb2J1c1N0YXJ0UmFpZFNjUnNwLnByb3RvGhFPSUlPTENQQkxDRi5w" + "cm90byJGChZIZWxpb2J1c1N0YXJ0UmFpZFNjUnNwEhsKBXNjZW5lGAogASgL" + "MgwuT0lJT0xDUEJMQ0YSDwoHcmV0Y29kZRgPIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			OIIOLCPBLCFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusStartRaidScRsp), HeliobusStartRaidScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
