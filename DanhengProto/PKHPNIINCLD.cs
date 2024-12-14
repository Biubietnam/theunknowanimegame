using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA5 RID: 3237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PKHPNIINCLD : IMessage<PKHPNIINCLD>, IMessage, IEquatable<PKHPNIINCLD>, IDeepCloneable<PKHPNIINCLD>, IBufferMessage
	{
		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x06008FEF RID: 36847 RVA: 0x0017C354 File Offset: 0x0017A554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PKHPNIINCLD> Parser
		{
			get
			{
				return PKHPNIINCLD._parser;
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06008FF0 RID: 36848 RVA: 0x0017C35B File Offset: 0x0017A55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PKHPNIINCLDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x0017C36D File Offset: 0x0017A56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PKHPNIINCLD.Descriptor;
			}
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0017C374 File Offset: 0x0017A574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKHPNIINCLD()
		{
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x0017C37C File Offset: 0x0017A57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKHPNIINCLD(PKHPNIINCLD other) : this()
		{
			this.magicUnitId_ = other.magicUnitId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x0017C3A1 File Offset: 0x0017A5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKHPNIINCLD Clone()
		{
			return new PKHPNIINCLD(this);
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x0017C3A9 File Offset: 0x0017A5A9
		// (set) Token: 0x06008FF6 RID: 36854 RVA: 0x0017C3B1 File Offset: 0x0017A5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitId
		{
			get
			{
				return this.magicUnitId_;
			}
			set
			{
				this.magicUnitId_ = value;
			}
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x0017C3BA File Offset: 0x0017A5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PKHPNIINCLD);
		}

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0017C3C8 File Offset: 0x0017A5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PKHPNIINCLD other)
		{
			return other != null && (other == this || (this.MagicUnitId == other.MagicUnitId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FF9 RID: 36857 RVA: 0x0017C3F8 File Offset: 0x0017A5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MagicUnitId != 0U)
			{
				num ^= this.MagicUnitId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FFA RID: 36858 RVA: 0x0017C437 File Offset: 0x0017A637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0017C43F File Offset: 0x0017A63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0017C448 File Offset: 0x0017A648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MagicUnitId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MagicUnitId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0017C47C File Offset: 0x0017A67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MagicUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0017C4BA File Offset: 0x0017A6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PKHPNIINCLD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MagicUnitId != 0U)
			{
				this.MagicUnitId = other.MagicUnitId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x0017C4EB File Offset: 0x0017A6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x0017C4F4 File Offset: 0x0017A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MagicUnitId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003743 RID: 14147
		private static readonly MessageParser<PKHPNIINCLD> _parser = new MessageParser<PKHPNIINCLD>(() => new PKHPNIINCLD());

		// Token: 0x04003744 RID: 14148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003745 RID: 14149
		public const int MagicUnitIdFieldNumber = 1;

		// Token: 0x04003746 RID: 14150
		private uint magicUnitId_;
	}
}
