using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200128E RID: 4750
	public static class SyncRogueFinishScNotifyReflection
	{
		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600D3F2 RID: 54258 RVA: 0x00235E72 File Offset: 0x00234072
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueFinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054D1 RID: 21713
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jUm9ndWVGaW5pc2hTY05vdGlmeS5wcm90bxoVUm9ndWVGaW5pc2hJ" + "bmZvLnByb3RvIkYKF1N5bmNSb2d1ZUZpbmlzaFNjTm90aWZ5EisKEXJvZ3Vl" + "X2ZpbmlzaF9pbmZvGAcgASgLMhAuUm9ndWVGaW5pc2hJbmZvQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueFinishInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueFinishScNotify), SyncRogueFinishScNotify.Parser, new string[]
			{
				"RogueFinishInfo"
			}, null, null, null, null)
		}));
	}
}
