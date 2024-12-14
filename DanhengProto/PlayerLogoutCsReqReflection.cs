using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CCA RID: 3274
	public static class PlayerLogoutCsReqReflection
	{
		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600920D RID: 37389 RVA: 0x001836B5 File Offset: 0x001818B5
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerLogoutCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400385E RID: 14430
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdQbGF5ZXJMb2dvdXRDc1JlcS5wcm90byITChFQbGF5ZXJMb2dvdXRDc1Jl" + "cUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLogoutCsReq), PlayerLogoutCsReq.Parser, null, null, null, null, null)
		}));
	}
}
