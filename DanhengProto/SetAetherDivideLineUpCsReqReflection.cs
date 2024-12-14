using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C4 RID: 4292
	public static class SetAetherDivideLineUpCsReqReflection
	{
		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600BF6D RID: 49005 RVA: 0x002036E6 File Offset: 0x002018E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAetherDivideLineUpCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004DB7 RID: 19895
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZXRBZXRoZXJEaXZpZGVMaW5lVXBDc1JlcS5wcm90bxocQWV0aGVyRGl2" + "aWRlTGluZXVwSW5mby5wcm90byJFChpTZXRBZXRoZXJEaXZpZGVMaW5lVXBD" + "c1JlcRInCgZsaW5ldXAYCCABKAsyFy5BZXRoZXJEaXZpZGVMaW5ldXBJbmZv" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AetherDivideLineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAetherDivideLineUpCsReq), SetAetherDivideLineUpCsReq.Parser, new string[]
			{
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
