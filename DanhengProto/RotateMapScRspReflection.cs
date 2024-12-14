using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001040 RID: 4160
	public static class RotateMapScRspReflection
	{
		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600B916 RID: 47382 RVA: 0x001F0EE2 File Offset: 0x001EF0E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return RotateMapScRspReflection.descriptor;
			}
		}

		// Token: 0x04004AFA RID: 19194
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSb3RhdGVNYXBTY1JzcC5wcm90bxoQTW90aW9uSW5mby5wcm90byJaCg5S" + "b3RhdGVNYXBTY1JzcBIPCgdyZXRjb2RlGAggASgNEhoKEmNsaWVudF9wb3Nf" + "dmVyc2lvbhgOIAEoDRIbCgZtb3Rpb24YBSABKAsyCy5Nb3Rpb25JbmZvQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RotateMapScRsp), RotateMapScRsp.Parser, new string[]
			{
				"Retcode",
				"ClientPosVersion",
				"Motion"
			}, null, null, null, null)
		}));
	}
}
