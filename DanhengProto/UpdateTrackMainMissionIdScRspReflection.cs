using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FE RID: 5118
	public static class UpdateTrackMainMissionIdScRspReflection
	{
		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x0600E43C RID: 58428 RVA: 0x0025EDC4 File Offset: 0x0025CFC4
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdScRspReflection.descriptor;
			}
		}

		// Token: 0x04005AAB RID: 23211
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNVcGRhdGVUcmFja01haW5NaXNzaW9uSWRTY1JzcC5wcm90byJpCh1VcGRh",
			"dGVUcmFja01haW5NaXNzaW9uSWRTY1JzcBIYChB0cmFja19taXNzaW9uX2lk",
			"GAQgASgNEh0KFXByZXZfdHJhY2tfbWlzc2lvbl9pZBgGIAEoDRIPCgdyZXRj",
			"b2RlGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateTrackMainMissionIdScRsp), UpdateTrackMainMissionIdScRsp.Parser, new string[]
			{
				"TrackMissionId",
				"PrevTrackMissionId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
