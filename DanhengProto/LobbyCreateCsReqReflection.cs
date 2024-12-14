using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A32 RID: 2610
	public static class LobbyCreateCsReqReflection
	{
		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x0013413B File Offset: 0x0013233B
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyCreateCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002C93 RID: 11411
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZMb2JieUNyZWF0ZUNzUmVxLnByb3RvGhFQR0RBQ05JQkZNUC5wcm90bxoT",
			"RmlnaHRHYW1lTW9kZS5wcm90byJaChBMb2JieUNyZWF0ZUNzUmVxEiMKC01H",
			"QUlBSkFLUEVJGA0gASgOMg4uRmlnaHRHYW1lTW9kZRIhCgtESUZOREVHTUtO",
			"QRgBIAEoCzIMLlBHREFDTklCRk1QQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PGDACNIBFMPReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyCreateCsReq), LobbyCreateCsReq.Parser, new string[]
			{
				"MGAIAJAKPEI",
				"DIFNDEGMKNA"
			}, null, null, null, null)
		}));
	}
}
