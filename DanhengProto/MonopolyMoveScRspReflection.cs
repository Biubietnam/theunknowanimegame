using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B62 RID: 2914
	public static class MonopolyMoveScRspReflection
	{
		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x001540E1 File Offset: 0x001522E1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyMoveScRspReflection.descriptor;
			}
		}

		// Token: 0x04003143 RID: 12611
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdNb25vcG9seU1vdmVTY1JzcC5wcm90bxoRQk1JQ0NCRE9DR0cucHJvdG8a",
			"EURIQUlKTVBBSkRMLnByb3RvImcKEU1vbm9wb2x5TW92ZVNjUnNwEg8KB3Jl",
			"dGNvZGUYDiABKA0SHgoIcm9vbV9tYXAYCiABKAsyDC5CTUlDQ0JET0NHRxIh",
			"CgtMSUFKRUhPSUFORxgDIAMoCzIMLkRIQUlKTVBBSkRMQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BMICCBDOCGGReflection.Descriptor,
			DHAIJMPAJDLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyMoveScRsp), MonopolyMoveScRsp.Parser, new string[]
			{
				"Retcode",
				"RoomMap",
				"LIAJEHOIANG"
			}, null, null, null, null)
		}));
	}
}
