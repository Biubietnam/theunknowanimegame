using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000196 RID: 406
	public static class ChallengeBossEquipmentInfoReflection
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0003432B File Offset: 0x0003252B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossEquipmentInfoReflection.descriptor;
			}
		}

		// Token: 0x0400079C RID: 1948
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBDaGFsbGVuZ2VCb3NzRXF1aXBtZW50SW5mby5wcm90byJsChpDaGFsbGVu",
			"Z2VCb3NzRXF1aXBtZW50SW5mbxIRCgl1bmlxdWVfaWQYAiABKA0SDQoFbGV2",
			"ZWwYBCABKA0SEQoJcHJvbW90aW9uGAogASgNEgwKBHJhbmsYDiABKA0SCwoD",
			"dGlkGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossEquipmentInfo), ChallengeBossEquipmentInfo.Parser, new string[]
			{
				"UniqueId",
				"Level",
				"Promotion",
				"Rank",
				"Tid"
			}, null, null, null, null)
		}));
	}
}
