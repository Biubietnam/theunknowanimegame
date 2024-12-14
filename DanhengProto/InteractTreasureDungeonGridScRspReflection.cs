using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200093C RID: 2364
	public static class InteractTreasureDungeonGridScRspReflection
	{
		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x00119ACC File Offset: 0x00117CCC
		public static FileDescriptor Descriptor
		{
			get
			{
				return InteractTreasureDungeonGridScRspReflection.descriptor;
			}
		}

		// Token: 0x04002870 RID: 10352
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZJbnRlcmFjdFRyZWFzdXJlRHVuZ2VvbkdyaWRTY1JzcC5wcm90bxoaVHJl",
			"YXN1cmVEdW5nZW9uTGV2ZWwucHJvdG8iXwogSW50ZXJhY3RUcmVhc3VyZUR1",
			"bmdlb25HcmlkU2NSc3ASKgoLTEhJRUNLUEpORkQYBiABKAsyFS5UcmVhc3Vy",
			"ZUR1bmdlb25MZXZlbBIPCgdyZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TreasureDungeonLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InteractTreasureDungeonGridScRsp), InteractTreasureDungeonGridScRsp.Parser, new string[]
			{
				"LHIECKPJNFD",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
