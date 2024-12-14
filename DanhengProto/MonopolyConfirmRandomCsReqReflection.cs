using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B1E RID: 2846
	public static class MonopolyConfirmRandomCsReqReflection
	{
		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06007E00 RID: 32256 RVA: 0x0014D379 File Offset: 0x0014B579
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyConfirmRandomCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003058 RID: 12376
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNb25vcG9seUNvbmZpcm1SYW5kb21Dc1JlcS5wcm90byIuChpNb25vcG9s" + "eUNvbmZpcm1SYW5kb21Dc1JlcRIQCghldmVudF9pZBgNIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyConfirmRandomCsReq), MonopolyConfirmRandomCsReq.Parser, new string[]
			{
				"EventId"
			}, null, null, null, null)
		}));
	}
}
