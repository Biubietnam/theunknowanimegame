using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3C RID: 3388
	public static class QuestReflection
	{
		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x00193BC2 File Offset: 0x00191DC2
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuestReflection.descriptor;
			}
		}

		// Token: 0x04003AE8 RID: 15080
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CgtRdWVzdC5wcm90bxoRUXVlc3RTdGF0dXMucHJvdG8ibQoFUXVlc3QSEwoL",
			"ZmluaXNoX3RpbWUYDiABKAMSHAoGc3RhdHVzGAYgASgOMgwuUXVlc3RTdGF0",
			"dXMSCgoCaWQYDyABKA0SEwoLSUFNSURPQUZLS0QYDSADKA0SEAoIcHJvZ3Jl",
			"c3MYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			QuestStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Quest), Quest.Parser, new string[]
			{
				"FinishTime",
				"Status",
				"Id",
				"IAMIDOAFKKD",
				"Progress"
			}, null, null, null, null)
		}));
	}
}
