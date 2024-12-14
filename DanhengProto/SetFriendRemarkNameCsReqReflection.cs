using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F4 RID: 4340
	public static class SetFriendRemarkNameCsReqReflection
	{
		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600C18A RID: 49546 RVA: 0x00208307 File Offset: 0x00206507
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetFriendRemarkNameCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E5E RID: 20062
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRGcmllbmRSZW1hcmtOYW1lQ3NSZXEucHJvdG8iTAoYU2V0RnJpZW5k" + "UmVtYXJrTmFtZUNzUmVxEgsKA3VpZBgNIAEoDRITCgtyZW1hcmtfbmFtZRgL" + "IAEoCRIOCgZyZWFzb24YDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendRemarkNameCsReq), SetFriendRemarkNameCsReq.Parser, new string[]
			{
				"Uid",
				"RemarkName",
				"Reason"
			}, null, null, null, null)
		}));
	}
}
