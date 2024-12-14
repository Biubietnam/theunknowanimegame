using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A4E RID: 2638
	public static class LobbyQuitCsReqReflection
	{
		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06007504 RID: 29956 RVA: 0x00136FF0 File Offset: 0x001351F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyQuitCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002D0B RID: 11531
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2JieVF1aXRDc1JlcS5wcm90byIQCg5Mb2JieVF1aXRDc1JlcUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyQuitCsReq), LobbyQuitCsReq.Parser, null, null, null, null, null)
		}));
	}
}
