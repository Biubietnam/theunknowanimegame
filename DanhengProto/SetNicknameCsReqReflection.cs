using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200111C RID: 4380
	public static class SetNicknameCsReqReflection
	{
		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600C350 RID: 50000 RVA: 0x0020C2BA File Offset: 0x0020A4BA
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetNicknameCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004EE8 RID: 20200
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXROaWNrbmFtZUNzUmVxLnByb3RvIjcKEFNldE5pY2tuYW1lQ3NSZXES" + "EQoJaXNfbW9kaWZ5GAIgASgIEhAKCG5pY2tuYW1lGAQgASgJQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetNicknameCsReq), SetNicknameCsReq.Parser, new string[]
			{
				"IsModify",
				"Nickname"
			}, null, null, null, null)
		}));
	}
}
