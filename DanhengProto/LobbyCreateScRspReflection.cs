using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A34 RID: 2612
	public static class LobbyCreateScRspReflection
	{
		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x060073ED RID: 29677 RVA: 0x001344F8 File Offset: 0x001326F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyCreateScRspReflection.descriptor;
			}
		}

		// Token: 0x04002C9A RID: 11418
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZMb2JieUNyZWF0ZVNjUnNwLnByb3RvGhFDQ0hDUE5MUEJESy5wcm90bxoT",
			"RmlnaHRHYW1lTW9kZS5wcm90byJ8ChBMb2JieUNyZWF0ZVNjUnNwEiEKC0VC",
			"TU9LUEJLTU1EGAIgAygLMgwuQ0NIQ1BOTFBCREsSIwoLTUdBSUFKQUtQRUkY",
			"BSABKA4yDi5GaWdodEdhbWVNb2RlEg8KB3JldGNvZGUYDyABKA0SDwoHcm9v",
			"bV9pZBgMIAEoBEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			CCHCPNLPBDKReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyCreateScRsp), LobbyCreateScRsp.Parser, new string[]
			{
				"EBMOKPBKMMD",
				"MGAIAJAKPEI",
				"Retcode",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
