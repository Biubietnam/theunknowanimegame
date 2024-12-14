using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001402 RID: 5122
	public static class UpgradeAreaScRspReflection
	{
		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x0600E46C RID: 58476 RVA: 0x0025F505 File Offset: 0x0025D705
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaScRspReflection.descriptor;
			}
		}

		// Token: 0x04005ABB RID: 23227
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZVcGdyYWRlQXJlYVNjUnNwLnByb3RvIkMKEFVwZ3JhZGVBcmVhU2NSc3AS" + "DwoHcmV0Y29kZRgGIAEoDRIPCgdhcmVhX2lkGAcgASgNEg0KBWxldmVsGAIg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaScRsp), UpgradeAreaScRsp.Parser, new string[]
			{
				"Retcode",
				"AreaId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
