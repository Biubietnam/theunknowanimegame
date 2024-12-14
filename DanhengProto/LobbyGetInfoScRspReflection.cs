using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A38 RID: 2616
	public static class LobbyGetInfoScRspReflection
	{
		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x00134B8E File Offset: 0x00132D8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyGetInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002CA9 RID: 11433
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdMb2JieUdldEluZm9TY1JzcC5wcm90bxoRQ0NIQ1BOTFBCREsucHJvdG8a",
			"E0ZpZ2h0R2FtZU1vZGUucHJvdG8ikgEKEUxvYmJ5R2V0SW5mb1NjUnNwEhMK",
			"C0dDSUdKRElNTkNFGA4gASgEEg8KB3JldGNvZGUYByABKA0SIwoLTUdBSUFK",
			"QUtQRUkYCSABKA4yDi5GaWdodEdhbWVNb2RlEiEKC0VCTU9LUEJLTU1EGAIg",
			"AygLMgwuQ0NIQ1BOTFBCREsSDwoHcm9vbV9pZBgMIAEoBEIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			CCHCPNLPBDKReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyGetInfoScRsp), LobbyGetInfoScRsp.Parser, new string[]
			{
				"GCIGJDIMNCE",
				"Retcode",
				"MGAIAJAKPEI",
				"EBMOKPBKMMD",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
