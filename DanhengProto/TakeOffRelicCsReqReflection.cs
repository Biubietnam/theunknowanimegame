using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001300 RID: 4864
	public static class TakeOffRelicCsReqReflection
	{
		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600D90F RID: 55567 RVA: 0x00242A06 File Offset: 0x00240C06
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeOffRelicCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400568E RID: 22158
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlT2ZmUmVsaWNDc1JlcS5wcm90byI/ChFUYWtlT2ZmUmVsaWNDc1Jl" + "cRIXCg9yZWxpY190eXBlX2xpc3QYBiADKA0SEQoJYXZhdGFyX2lkGAEgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffRelicCsReq), TakeOffRelicCsReq.Parser, new string[]
			{
				"RelicTypeList",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
