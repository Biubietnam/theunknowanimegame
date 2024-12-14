using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A8 RID: 4520
	public static class StartCocoonStageCsReqReflection
	{
		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600C9D5 RID: 51669 RVA: 0x0021D62C File Offset: 0x0021B82C
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartCocoonStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005168 RID: 20840
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTdGFydENvY29vblN0YWdlQ3NSZXEucHJvdG8iZQoVU3RhcnRDb2Nvb25T" + "dGFnZUNzUmVxEhYKDnByb3BfZW50aXR5X2lkGAggASgNEhEKCWNvY29vbl9p" + "ZBgHIAEoDRITCgt3b3JsZF9sZXZlbBgEIAEoDRIMCgR3YXZlGAkgASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartCocoonStageCsReq), StartCocoonStageCsReq.Parser, new string[]
			{
				"PropEntityId",
				"CocoonId",
				"WorldLevel",
				"Wave"
			}, null, null, null, null)
		}));
	}
}
