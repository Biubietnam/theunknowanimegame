using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000202 RID: 514
	public static class ChessRogueDiceReflection
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x000419D7 File Offset: 0x0003FBD7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceReflection.descriptor;
			}
		}

		// Token: 0x040009A8 RID: 2472
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRDaGVzc1JvZ3VlRGljZS5wcm90bxofQ2hlc3NSb2d1ZURpY2VTdXJmYWNl",
			"SW5mby5wcm90byJ6Cg5DaGVzc1JvZ3VlRGljZRIRCglicmFuY2hfaWQYByAB",
			"KA0SMAoMc3VyZmFjZV9saXN0GAQgAygLMhouQ2hlc3NSb2d1ZURpY2VTdXJm",
			"YWNlSW5mbxISCgpzdXJmYWNlX2lkGAYgASgNEg8KB3Nsb3RfaWQYCSABKA1C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueDiceSurfaceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueDice), ChessRogueDice.Parser, new string[]
			{
				"BranchId",
				"SurfaceList",
				"SurfaceId",
				"SlotId"
			}, null, null, null, null)
		}));
	}
}
