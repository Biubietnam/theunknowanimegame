using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AC RID: 4524
	public static class StartFightFestCsReqReflection
	{
		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600CA0D RID: 51725 RVA: 0x0021E09E File Offset: 0x0021C29E
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartFightFestCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005180 RID: 20864
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTdGFydEZpZ2h0RmVzdENzUmVxLnByb3RvGhFCTkJNRk1NQklBTy5wcm90",
			"bxoTRmlnaHRGZXN0VHlwZS5wcm90byKJAQoTU3RhcnRGaWdodEZlc3RDc1Jl",
			"cRIcCgR0eXBlGA8gASgOMg4uRmlnaHRGZXN0VHlwZRIQCghldmVudF9pZBgN",
			"IAEoDRITCgtKSklQSkJFQUpJSBgMIAMoDRIhCgthdmF0YXJfbGlzdBgLIAMo",
			"CzIMLkJOQk1GTU1CSUFPEgoKAmlkGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BNBMFMMBIAOReflection.Descriptor,
			FightFestTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartFightFestCsReq), StartFightFestCsReq.Parser, new string[]
			{
				"Type",
				"EventId",
				"JJIPJBEAJIH",
				"AvatarList",
				"Id"
			}, null, null, null, null)
		}));
	}
}
