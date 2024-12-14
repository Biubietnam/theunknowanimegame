using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000364 RID: 868
	public static class DeactivateFarmElementCsReqReflection
	{
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0006C9A1 File Offset: 0x0006ABA1
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeactivateFarmElementCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000FAB RID: 4011
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWFjdGl2YXRlRmFybUVsZW1lbnRDc1JlcS5wcm90byIvChpEZWFjdGl2" + "YXRlRmFybUVsZW1lbnRDc1JlcRIRCgllbnRpdHlfaWQYAyABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeactivateFarmElementCsReq), DeactivateFarmElementCsReq.Parser, new string[]
			{
				"EntityId"
			}, null, null, null, null)
		}));
	}
}
