using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001168 RID: 4456
	public static class SpaceZooExchangeItemScRspReflection
	{
		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600C6D5 RID: 50901 RVA: 0x00215B2E File Offset: 0x00213D2E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpaceZooExchangeItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04005058 RID: 20568
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TcGFjZVpvb0V4Y2hhbmdlSXRlbVNjUnNwLnByb3RvIj0KGVNwYWNlWm9v" + "RXhjaGFuZ2VJdGVtU2NSc3ASDwoHaXRlbV9pZBgOIAEoDRIPCgdyZXRjb2Rl" + "GAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooExchangeItemScRsp), SpaceZooExchangeItemScRsp.Parser, new string[]
			{
				"ItemId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
