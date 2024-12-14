using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200038C RID: 908
	public static class DestroyItemScRspReflection
	{
		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000705C8 File Offset: 0x0006E7C8
		public static FileDescriptor Descriptor
		{
			get
			{
				return DestroyItemScRspReflection.descriptor;
			}
		}

		// Token: 0x0400103A RID: 4154
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEZXN0cm95SXRlbVNjUnNwLnByb3RvIjsKEERlc3Ryb3lJdGVtU2NSc3AS" + "FgoOY3VyX2l0ZW1fY291bnQYBCABKA0SDwoHcmV0Y29kZRgBIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DestroyItemScRsp), DestroyItemScRsp.Parser, new string[]
			{
				"CurItemCount",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
