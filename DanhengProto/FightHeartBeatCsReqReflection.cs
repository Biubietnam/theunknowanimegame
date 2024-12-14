using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000536 RID: 1334
	public static class FightHeartBeatCsReqReflection
	{
		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x000A3BB0 File Offset: 0x000A1DB0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightHeartBeatCsReqReflection.descriptor;
			}
		}

		// Token: 0x040017F9 RID: 6137
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaWdodEhlYXJ0QmVhdENzUmVxLnByb3RvIi0KE0ZpZ2h0SGVhcnRCZWF0" + "Q3NSZXESFgoOY2xpZW50X3RpbWVfbXMYDiABKARCHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightHeartBeatCsReq), FightHeartBeatCsReq.Parser, new string[]
			{
				"ClientTimeMs"
			}, null, null, null, null)
		}));
	}
}
