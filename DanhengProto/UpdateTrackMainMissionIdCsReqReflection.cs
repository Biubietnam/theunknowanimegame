using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FC RID: 5116
	public static class UpdateTrackMainMissionIdCsReqReflection
	{
		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0600E423 RID: 58403 RVA: 0x0025E9A5 File Offset: 0x0025CBA5
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005AA2 RID: 23202
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNVcGRhdGVUcmFja01haW5NaXNzaW9uSWRDc1JlcS5wcm90bxokVHJhY2tN",
			"YWluTWlzc2lvblVwZGF0ZVJlYXNvbklkLnByb3RvIoQBCh1VcGRhdGVUcmFj",
			"a01haW5NaXNzaW9uSWRDc1JlcRI0CgtKS0pOTUtNSURCUBgEIAEoDjIfLlRy",
			"YWNrTWFpbk1pc3Npb25VcGRhdGVSZWFzb25JZBITCgtJTENDQkNPSkVPSBgH",
			"IAEoDRIYChB0cmFja19taXNzaW9uX2lkGA4gASgNQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TrackMainMissionUpdateReasonIdReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateTrackMainMissionIdCsReq), UpdateTrackMainMissionIdCsReq.Parser, new string[]
			{
				"JKJNMKMIDBP",
				"ILCCBCOJEOH",
				"TrackMissionId"
			}, null, null, null, null)
		}));
	}
}
