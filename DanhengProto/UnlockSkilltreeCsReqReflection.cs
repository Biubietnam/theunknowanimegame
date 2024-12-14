using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C6 RID: 5062
	public static class UnlockSkilltreeCsReqReflection
	{
		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0600E1AD RID: 57773 RVA: 0x002586E6 File Offset: 0x002568E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockSkilltreeCsReqReflection.descriptor;
			}
		}

		// Token: 0x040059CE RID: 22990
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tTa2lsbHRyZWVDc1JlcS5wcm90bxoOSXRlbUNvc3QucHJvdG8i" + "VQoUVW5sb2NrU2tpbGx0cmVlQ3NSZXESEAoIcG9pbnRfaWQYAyABKA0SHAoJ" + "aXRlbV9saXN0GAwgAygLMgkuSXRlbUNvc3QSDQoFbGV2ZWwYCSABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockSkilltreeCsReq), UnlockSkilltreeCsReq.Parser, new string[]
			{
				"PointId",
				"ItemList",
				"Level"
			}, null, null, null, null)
		}));
	}
}
