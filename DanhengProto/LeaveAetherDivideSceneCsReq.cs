using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009ED RID: 2541
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveAetherDivideSceneCsReq : IMessage<LeaveAetherDivideSceneCsReq>, IMessage, IEquatable<LeaveAetherDivideSceneCsReq>, IDeepCloneable<LeaveAetherDivideSceneCsReq>, IBufferMessage
	{
		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060070D4 RID: 28884 RVA: 0x0012CCC3 File Offset: 0x0012AEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveAetherDivideSceneCsReq> Parser
		{
			get
			{
				return LeaveAetherDivideSceneCsReq._parser;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060070D5 RID: 28885 RVA: 0x0012CCCA File Offset: 0x0012AECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveAetherDivideSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060070D6 RID: 28886 RVA: 0x0012CCDC File Offset: 0x0012AEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveAetherDivideSceneCsReq.Descriptor;
			}
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x0012CCE3 File Offset: 0x0012AEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneCsReq()
		{
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x0012CCEB File Offset: 0x0012AEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneCsReq(LeaveAetherDivideSceneCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x0012CD04 File Offset: 0x0012AF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneCsReq Clone()
		{
			return new LeaveAetherDivideSceneCsReq(this);
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x0012CD0C File Offset: 0x0012AF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveAetherDivideSceneCsReq);
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x0012CD1A File Offset: 0x0012AF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveAetherDivideSceneCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x0012CD38 File Offset: 0x0012AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x0012CD5E File Offset: 0x0012AF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x0012CD66 File Offset: 0x0012AF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x0012CD6F File Offset: 0x0012AF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x0012CD88 File Offset: 0x0012AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x0012CDAE File Offset: 0x0012AFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveAetherDivideSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x0012CDCB File Offset: 0x0012AFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x0012CDD4 File Offset: 0x0012AFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B7F RID: 11135
		private static readonly MessageParser<LeaveAetherDivideSceneCsReq> _parser = new MessageParser<LeaveAetherDivideSceneCsReq>(() => new LeaveAetherDivideSceneCsReq());

		// Token: 0x04002B80 RID: 11136
		private UnknownFieldSet _unknownFields;
	}
}
