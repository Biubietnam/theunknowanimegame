using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D8 RID: 5080
	public static class UpdateFloorSavedValueNotifyReflection
	{
		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x0025A360 File Offset: 0x00258560
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateFloorSavedValueNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A0B RID: 23051
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFVcGRhdGVGbG9vclNhdmVkVmFsdWVOb3RpZnkucHJvdG8izQEKG1VwZGF0",
			"ZUZsb29yU2F2ZWRWYWx1ZU5vdGlmeRIQCghmbG9vcl9pZBgPIAEoDRIQCghw",
			"bGFuZV9pZBgCIAEoDRJBCgtzYXZlZF92YWx1ZRgKIAMoCzIsLlVwZGF0ZUZs",
			"b29yU2F2ZWRWYWx1ZU5vdGlmeS5TYXZlZFZhbHVlRW50cnkSFAoMZGltZW5z",
			"aW9uX2lkGAUgASgNGjEKD1NhdmVkVmFsdWVFbnRyeRILCgNrZXkYASABKAkS",
			"DQoFdmFsdWUYAiABKAU6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateFloorSavedValueNotify), UpdateFloorSavedValueNotify.Parser, new string[]
			{
				"FloorId",
				"PlaneId",
				"SavedValue",
				"DimensionId"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
