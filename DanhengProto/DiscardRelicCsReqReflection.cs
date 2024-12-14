using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A4 RID: 932
	public static class DiscardRelicCsReqReflection
	{
		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000730D9 File Offset: 0x000712D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return DiscardRelicCsReqReflection.descriptor;
			}
		}

		// Token: 0x040010B1 RID: 4273
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEaXNjYXJkUmVsaWNDc1JlcS5wcm90byJaChFEaXNjYXJkUmVsaWNDc1Jl" + "cRISCgppc19kaXNjYXJkGAMgASgIEhMKC09LS0pGSUJOR0NFGAsgASgIEhwK" + "FHJlbGljX3VuaXF1ZV9pZF9saXN0GAogAygNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DiscardRelicCsReq), DiscardRelicCsReq.Parser, new string[]
			{
				"IsDiscard",
				"OKKJFIBNGCE",
				"RelicUniqueIdList"
			}, null, null, null, null)
		}));
	}
}
