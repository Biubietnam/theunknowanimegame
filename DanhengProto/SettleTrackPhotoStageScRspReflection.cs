using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200113C RID: 4412
	public static class SettleTrackPhotoStageScRspReflection
	{
		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600C4CF RID: 50383 RVA: 0x002103BD File Offset: 0x0020E5BD
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettleTrackPhotoStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04004F81 RID: 20353
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTZXR0bGVUcmFja1Bob3RvU3RhZ2VTY1JzcC5wcm90bxoRSE9FTEJORkJH",
			"SEIucHJvdG8idAoaU2V0dGxlVHJhY2tQaG90b1N0YWdlU2NSc3ASIQoLUE1F",
			"SERHSUxORUYYBiADKAsyDC5IT0VMQk5GQkdIQhIQCghzY29yZV9pZBgKIAEo",
			"DRIQCghzdGFnZV9pZBgMIAEoDRIPCgdyZXRjb2RlGAIgASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			HOELBNFBGHBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SettleTrackPhotoStageScRsp), SettleTrackPhotoStageScRsp.Parser, new string[]
			{
				"PMEHDGILNEF",
				"ScoreId",
				"StageId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
