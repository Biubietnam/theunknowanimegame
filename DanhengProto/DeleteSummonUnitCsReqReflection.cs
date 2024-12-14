using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200037C RID: 892
	public static class DeleteSummonUnitCsReqReflection
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x0006EBCE File Offset: 0x0006CDCE
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteSummonUnitCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001000 RID: 4096
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEZWxldGVTdW1tb25Vbml0Q3NSZXEucHJvdG8iLwoVRGVsZXRlU3VtbW9u" + "VW5pdENzUmVxEhYKDmVudGl0eV9pZF9saXN0GAcgAygNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteSummonUnitCsReq), DeleteSummonUnitCsReq.Parser, new string[]
			{
				"EntityIdList"
			}, null, null, null, null)
		}));
	}
}
