using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F6 RID: 4342
	public static class SetFriendRemarkNameScRspReflection
	{
		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600C1A3 RID: 49571 RVA: 0x0020871C File Offset: 0x0020691C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetFriendRemarkNameScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E67 RID: 20071
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRGcmllbmRSZW1hcmtOYW1lU2NSc3AucHJvdG8iTQoYU2V0RnJpZW5k" + "UmVtYXJrTmFtZVNjUnNwEgsKA3VpZBgIIAEoDRITCgtyZW1hcmtfbmFtZRgO" + "IAEoCRIPCgdyZXRjb2RlGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendRemarkNameScRsp), SetFriendRemarkNameScRsp.Parser, new string[]
			{
				"Uid",
				"RemarkName",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
