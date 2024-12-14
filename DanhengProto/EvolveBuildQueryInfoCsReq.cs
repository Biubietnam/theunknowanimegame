using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B1 RID: 1201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildQueryInfoCsReq : IMessage<EvolveBuildQueryInfoCsReq>, IMessage, IEquatable<EvolveBuildQueryInfoCsReq>, IDeepCloneable<EvolveBuildQueryInfoCsReq>, IBufferMessage
	{
		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x00093EE3 File Offset: 0x000920E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildQueryInfoCsReq> Parser
		{
			get
			{
				return EvolveBuildQueryInfoCsReq._parser;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x00093EEA File Offset: 0x000920EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildQueryInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x00093EFC File Offset: 0x000920FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildQueryInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00093F03 File Offset: 0x00092103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoCsReq()
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00093F0B File Offset: 0x0009210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoCsReq(EvolveBuildQueryInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00093F24 File Offset: 0x00092124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoCsReq Clone()
		{
			return new EvolveBuildQueryInfoCsReq(this);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00093F2C File Offset: 0x0009212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildQueryInfoCsReq);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00093F3A File Offset: 0x0009213A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildQueryInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00093F58 File Offset: 0x00092158
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

		// Token: 0x060035BA RID: 13754 RVA: 0x00093F7E File Offset: 0x0009217E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00093F86 File Offset: 0x00092186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00093F8F File Offset: 0x0009218F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00093FA8 File Offset: 0x000921A8
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

		// Token: 0x060035BE RID: 13758 RVA: 0x00093FCE File Offset: 0x000921CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildQueryInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00093FEB File Offset: 0x000921EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00093FF4 File Offset: 0x000921F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400156C RID: 5484
		private static readonly MessageParser<EvolveBuildQueryInfoCsReq> _parser = new MessageParser<EvolveBuildQueryInfoCsReq>(() => new EvolveBuildQueryInfoCsReq());

		// Token: 0x0400156D RID: 5485
		private UnknownFieldSet _unknownFields;
	}
}
