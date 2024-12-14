using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012BC RID: 4796
	public static class TakeAssistRewardScRspReflection
	{
		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x0023AC32 File Offset: 0x00238E32
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeAssistRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005577 RID: 21879
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtUYWtlQXNzaXN0UmV3YXJkU2NSc3AucHJvdG8aEUFDUERBR01QQ1BDLnBy",
			"b3RvGg5JdGVtTGlzdC5wcm90byJmChVUYWtlQXNzaXN0UmV3YXJkU2NSc3AS",
			"GQoGcmV3YXJkGA4gASgLMgkuSXRlbUxpc3QSIQoLTkNLUEpESEVOTUoYBSAD",
			"KAsyDC5BQ1BEQUdNUENQQxIPCgdyZXRjb2RlGAQgASgNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ACPDAGMPCPCReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeAssistRewardScRsp), TakeAssistRewardScRsp.Parser, new string[]
			{
				"Reward",
				"NCKPJDHENMJ",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
