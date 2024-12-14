using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB2 RID: 3506
	public static class RemoveRotaterScRspReflection
	{
		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x001A1B25 File Offset: 0x0019FD25
		public static FileDescriptor Descriptor
		{
			get
			{
				return RemoveRotaterScRspReflection.descriptor;
			}
		}

		// Token: 0x04003CF7 RID: 15607
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSZW1vdmVSb3RhdGVyU2NSc3AucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv",
			"GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byJyChJSZW1vdmVSb3RhdGVyU2NS",
			"c3ASJwoLZW5lcmd5X2luZm8YCSABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mbxIP",
			"CgdyZXRjb2RlGAMgASgNEiIKDHJvdGF0ZXJfZGF0YRgGIAEoCzIMLlJvdGF0",
			"ZXJEYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RemoveRotaterScRsp), RemoveRotaterScRsp.Parser, new string[]
			{
				"EnergyInfo",
				"Retcode",
				"RotaterData"
			}, null, null, null, null)
		}));
	}
}
