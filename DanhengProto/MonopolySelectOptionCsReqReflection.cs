using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B76 RID: 2934
	public static class MonopolySelectOptionCsReqReflection
	{
		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x060081DF RID: 33247 RVA: 0x0015615F File Offset: 0x0015435F
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolySelectOptionCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003189 RID: 12681
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Nb25vcG9seVNlbGVjdE9wdGlvbkNzUmVxLnByb3RvIkAKGU1vbm9wb2x5" + "U2VsZWN0T3B0aW9uQ3NSZXESEQoJb3B0aW9uX2lkGA4gASgNEhAKCGV2ZW50" + "X2lkGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolySelectOptionCsReq), MonopolySelectOptionCsReq.Parser, new string[]
			{
				"OptionId",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
