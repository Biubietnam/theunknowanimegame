using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A42 RID: 2626
	public static class LobbyJoinScRspReflection
	{
		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x00135E88 File Offset: 0x00134088
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyJoinScRspReflection.descriptor;
			}
		}

		// Token: 0x04002CD5 RID: 11477
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRMb2JieUpvaW5TY1JzcC5wcm90bxoRQ0NIQ1BOTFBCREsucHJvdG8aE0Zp",
			"Z2h0R2FtZU1vZGUucHJvdG8iegoOTG9iYnlKb2luU2NSc3ASIQoLRUJNT0tQ",
			"QktNTUQYBSADKAsyDC5DQ0hDUE5MUEJESxIjCgtNR0FJQUpBS1BFSRgLIAEo",
			"DjIOLkZpZ2h0R2FtZU1vZGUSDwoHcm9vbV9pZBgDIAEoBBIPCgdyZXRjb2Rl",
			"GAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			CCHCPNLPBDKReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyJoinScRsp), LobbyJoinScRsp.Parser, new string[]
			{
				"EBMOKPBKMMD",
				"MGAIAJAKPEI",
				"RoomId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
