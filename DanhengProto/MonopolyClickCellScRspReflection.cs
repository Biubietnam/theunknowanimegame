using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B16 RID: 2838
	public static class MonopolyClickCellScRspReflection
	{
		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06007DAA RID: 32170 RVA: 0x0014C8A1 File Offset: 0x0014AAA1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyClickCellScRspReflection.descriptor;
			}
		}

		// Token: 0x04003042 RID: 12354
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNsaWNrQ2VsbFNjUnNwLnByb3RvIkoKFk1vbm9wb2x5Q2xp" + "Y2tDZWxsU2NSc3ASDwoHY2VsbF9pZBgDIAEoDRIOCgZtYXBfaWQYDiABKA0S" + "DwoHcmV0Y29kZRgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyClickCellScRsp), MonopolyClickCellScRsp.Parser, new string[]
			{
				"CellId",
				"MapId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
