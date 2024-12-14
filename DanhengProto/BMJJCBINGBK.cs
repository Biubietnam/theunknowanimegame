using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000133 RID: 307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BMJJCBINGBK : IMessage<BMJJCBINGBK>, IMessage, IEquatable<BMJJCBINGBK>, IDeepCloneable<BMJJCBINGBK>, IBufferMessage
	{
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000294D8 File Offset: 0x000276D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BMJJCBINGBK> Parser
		{
			get
			{
				return BMJJCBINGBK._parser;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x000294DF File Offset: 0x000276DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BMJJCBINGBKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000294F1 File Offset: 0x000276F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BMJJCBINGBK.Descriptor;
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000294F8 File Offset: 0x000276F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMJJCBINGBK()
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00029500 File Offset: 0x00027700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMJJCBINGBK(BMJJCBINGBK other) : this()
		{
			this.tournFormulaId_ = other.tournFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00029525 File Offset: 0x00027725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMJJCBINGBK Clone()
		{
			return new BMJJCBINGBK(this);
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0002952D File Offset: 0x0002772D
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00029535 File Offset: 0x00027735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TournFormulaId
		{
			get
			{
				return this.tournFormulaId_;
			}
			set
			{
				this.tournFormulaId_ = value;
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002953E File Offset: 0x0002773E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BMJJCBINGBK);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002954C File Offset: 0x0002774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BMJJCBINGBK other)
		{
			return other != null && (other == this || (this.TournFormulaId == other.TournFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0002957C File Offset: 0x0002777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TournFormulaId != 0U)
			{
				num ^= this.TournFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000295BB File Offset: 0x000277BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000295C3 File Offset: 0x000277C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000295CC File Offset: 0x000277CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TournFormulaId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00029600 File Offset: 0x00027800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TournFormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0002963E File Offset: 0x0002783E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BMJJCBINGBK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TournFormulaId != 0U)
			{
				this.TournFormulaId = other.TournFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002966F File Offset: 0x0002786F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00029678 File Offset: 0x00027878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TournFormulaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000600 RID: 1536
		private static readonly MessageParser<BMJJCBINGBK> _parser = new MessageParser<BMJJCBINGBK>(() => new BMJJCBINGBK());

		// Token: 0x04000601 RID: 1537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000602 RID: 1538
		public const int TournFormulaIdFieldNumber = 13;

		// Token: 0x04000603 RID: 1539
		private uint tournFormulaId_;
	}
}
