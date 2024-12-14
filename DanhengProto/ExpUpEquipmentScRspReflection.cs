using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004EA RID: 1258
	public static class ExpUpEquipmentScRspReflection
	{
		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0009A467 File Offset: 0x00098667
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExpUpEquipmentScRspReflection.descriptor;
			}
		}

		// Token: 0x04001647 RID: 5703
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFeHBVcEVxdWlwbWVudFNjUnNwLnByb3RvGg5QaWxlSXRlbS5wcm90byJL" + "ChNFeHBVcEVxdWlwbWVudFNjUnNwEiMKEHJldHVybl9pdGVtX2xpc3QYBCAD" + "KAsyCS5QaWxlSXRlbRIPCgdyZXRjb2RlGAkgASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PileItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpEquipmentScRsp), ExpUpEquipmentScRsp.Parser, new string[]
			{
				"ReturnItemList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
