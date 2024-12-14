using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000921 RID: 2337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IGKDCOEOPMD : IMessage<IGKDCOEOPMD>, IMessage, IEquatable<IGKDCOEOPMD>, IDeepCloneable<IGKDCOEOPMD>, IBufferMessage
	{
		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600683F RID: 26687 RVA: 0x00116778 File Offset: 0x00114978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IGKDCOEOPMD> Parser
		{
			get
			{
				return IGKDCOEOPMD._parser;
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x0011677F File Offset: 0x0011497F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IGKDCOEOPMDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x00116791 File Offset: 0x00114991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IGKDCOEOPMD.Descriptor;
			}
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x00116798 File Offset: 0x00114998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGKDCOEOPMD()
		{
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x001167A0 File Offset: 0x001149A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGKDCOEOPMD(IGKDCOEOPMD other) : this()
		{
			this.miracleSelectId_ = other.miracleSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x001167C5 File Offset: 0x001149C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGKDCOEOPMD Clone()
		{
			return new IGKDCOEOPMD(this);
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06006845 RID: 26693 RVA: 0x001167CD File Offset: 0x001149CD
		// (set) Token: 0x06006846 RID: 26694 RVA: 0x001167D5 File Offset: 0x001149D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleSelectId
		{
			get
			{
				return this.miracleSelectId_;
			}
			set
			{
				this.miracleSelectId_ = value;
			}
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x001167DE File Offset: 0x001149DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IGKDCOEOPMD);
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x001167EC File Offset: 0x001149EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IGKDCOEOPMD other)
		{
			return other != null && (other == this || (this.MiracleSelectId == other.MiracleSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x0011681C File Offset: 0x00114A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MiracleSelectId != 0U)
			{
				num ^= this.MiracleSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x0011685B File Offset: 0x00114A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00116863 File Offset: 0x00114A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x0011686C File Offset: 0x00114A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleSelectId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x001168A0 File Offset: 0x00114AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MiracleSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x001168DE File Offset: 0x00114ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IGKDCOEOPMD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MiracleSelectId != 0U)
			{
				this.MiracleSelectId = other.MiracleSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x0011690F File Offset: 0x00114B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x00116918 File Offset: 0x00114B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002803 RID: 10243
		private static readonly MessageParser<IGKDCOEOPMD> _parser = new MessageParser<IGKDCOEOPMD>(() => new IGKDCOEOPMD());

		// Token: 0x04002804 RID: 10244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002805 RID: 10245
		public const int MiracleSelectIdFieldNumber = 10;

		// Token: 0x04002806 RID: 10246
		private uint miracleSelectId_;
	}
}
