using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200141A RID: 5146
	public static class WaypointReflection
	{
		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x0600E59A RID: 58778 RVA: 0x002626CC File Offset: 0x002608CC
		public static FileDescriptor Descriptor
		{
			get
			{
				return WaypointReflection.descriptor;
			}
		}

		// Token: 0x04005B2D RID: 23341
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5XYXlwb2ludC5wcm90byI7CghXYXlwb2ludBIKCgJpZBgOIAEoDRIOCgZp" + "c19uZXcYASABKAgSEwoLR05GRENPSEdHRlAYBSABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Waypoint), Waypoint.Parser, new string[]
			{
				"Id",
				"IsNew",
				"GNFDCOHGGFP"
			}, null, null, null, null)
		}));
	}
}
