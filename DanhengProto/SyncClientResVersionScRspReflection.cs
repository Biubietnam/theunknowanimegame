using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200126E RID: 4718
	public static class SyncClientResVersionScRspReflection
	{
		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600D2A2 RID: 53922 RVA: 0x00232C0D File Offset: 0x00230E0D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncClientResVersionScRspReflection.descriptor;
			}
		}

		// Token: 0x04005462 RID: 21602
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TeW5jQ2xpZW50UmVzVmVyc2lvblNjUnNwLnByb3RvIkEKGVN5bmNDbGll" + "bnRSZXNWZXJzaW9uU2NSc3ASDwoHcmV0Y29kZRgMIAEoDRITCgtyZXNfdmVy" + "c2lvbhgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncClientResVersionScRsp), SyncClientResVersionScRsp.Parser, new string[]
			{
				"Retcode",
				"ResVersion"
			}, null, null, null, null)
		}));
	}
}
