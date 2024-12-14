using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001448 RID: 5192
	public static class WorkbenchReforgeHexAvatarFuncReflection
	{
		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0600E7C2 RID: 59330 RVA: 0x002682BA File Offset: 0x002664BA
		public static FileDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeHexAvatarFuncReflection.descriptor;
			}
		}

		// Token: 0x04005BF3 RID: 23539
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNXb3JrYmVuY2hSZWZvcmdlSGV4QXZhdGFyRnVuYy5wcm90bxoSSXRlbUNv",
			"c3REYXRhLnByb3RvInoKHVdvcmtiZW5jaFJlZm9yZ2VIZXhBdmF0YXJGdW5j",
			"EhgKEGZyZWVfcmVmb3JnZV9udW0YASABKA0SIAoJY29zdF9kYXRhGAogASgL",
			"Mg0uSXRlbUNvc3REYXRhEh0KFWludF9yZWZvcmdlX251bV92YWx1ZRgFIAEo",
			"BUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WorkbenchReforgeHexAvatarFunc), WorkbenchReforgeHexAvatarFunc.Parser, new string[]
			{
				"FreeReforgeNum",
				"CostData",
				"IntReforgeNumValue"
			}, null, null, null, null)
		}));
	}
}
