using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000626 RID: 1574
	public static class GetAvatarDataCsReqReflection
	{
		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x000C1440 File Offset: 0x000BF640
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAvatarDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001C34 RID: 7220
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRBdmF0YXJEYXRhQ3NSZXEucHJvdG8iRQoSR2V0QXZhdGFyRGF0YUNz" + "UmVxEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYBCADKA0SEgoKaXNfZ2V0X2Fs" + "bBgIIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarDataCsReq), GetAvatarDataCsReq.Parser, new string[]
			{
				"BaseAvatarIdList",
				"IsGetAll"
			}, null, null, null, null)
		}));
	}
}
