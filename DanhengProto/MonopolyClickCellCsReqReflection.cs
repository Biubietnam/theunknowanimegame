using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B14 RID: 2836
	public static class MonopolyClickCellCsReqReflection
	{
		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0014C56D File Offset: 0x0014A76D
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyClickCellCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400303B RID: 12347
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNsaWNrQ2VsbENzUmVxLnByb3RvIjkKFk1vbm9wb2x5Q2xp" + "Y2tDZWxsQ3NSZXESDgoGbWFwX2lkGA0gASgNEg8KB2NlbGxfaWQYDiABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyClickCellCsReq), MonopolyClickCellCsReq.Parser, new string[]
			{
				"MapId",
				"CellId"
			}, null, null, null, null)
		}));
	}
}
