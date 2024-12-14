using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B7 RID: 1463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FormulaInfo : IMessage<FormulaInfo>, IMessage, IEquatable<FormulaInfo>, IDeepCloneable<FormulaInfo>, IBufferMessage
	{
		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x000B2397 File Offset: 0x000B0597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormulaInfo> Parser
		{
			get
			{
				return FormulaInfo._parser;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x000B239E File Offset: 0x000B059E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FormulaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x000B23B0 File Offset: 0x000B05B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormulaInfo.Descriptor;
			}
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x000B23B7 File Offset: 0x000B05B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaInfo()
		{
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x000B23CC File Offset: 0x000B05CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaInfo(FormulaInfo other) : this()
		{
			this.isExpand_ = other.isExpand_;
			this.formulaBuffTypeList_ = other.formulaBuffTypeList_.Clone();
			this.formulaId_ = other.formulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x000B2419 File Offset: 0x000B0619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaInfo Clone()
		{
			return new FormulaInfo(this);
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x000B2421 File Offset: 0x000B0621
		// (set) Token: 0x0600416F RID: 16751 RVA: 0x000B2429 File Offset: 0x000B0629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExpand
		{
			get
			{
				return this.isExpand_;
			}
			set
			{
				this.isExpand_ = value;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x000B2432 File Offset: 0x000B0632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormulaBuffTypeInfo> FormulaBuffTypeList
		{
			get
			{
				return this.formulaBuffTypeList_;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x000B243A File Offset: 0x000B063A
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x000B2442 File Offset: 0x000B0642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FormulaId
		{
			get
			{
				return this.formulaId_;
			}
			set
			{
				this.formulaId_ = value;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x000B244B File Offset: 0x000B064B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormulaInfo);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x000B245C File Offset: 0x000B065C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormulaInfo other)
		{
			return other != null && (other == this || (this.IsExpand == other.IsExpand && this.formulaBuffTypeList_.Equals(other.formulaBuffTypeList_) && this.FormulaId == other.FormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000B24BC File Offset: 0x000B06BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsExpand)
			{
				num ^= this.IsExpand.GetHashCode();
			}
			num ^= this.formulaBuffTypeList_.GetHashCode();
			if (this.FormulaId != 0U)
			{
				num ^= this.FormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x000B2522 File Offset: 0x000B0722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x000B252A File Offset: 0x000B072A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x000B2534 File Offset: 0x000B0734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formulaBuffTypeList_.WriteTo(ref output, FormulaInfo._repeated_formulaBuffTypeList_codec);
			if (this.FormulaId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FormulaId);
			}
			if (this.IsExpand)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsExpand);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000B25A0 File Offset: 0x000B07A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsExpand)
			{
				num += 2;
			}
			num += this.formulaBuffTypeList_.CalculateSize(FormulaInfo._repeated_formulaBuffTypeList_codec);
			if (this.FormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x000B2600 File Offset: 0x000B0800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsExpand)
			{
				this.IsExpand = other.IsExpand;
			}
			this.formulaBuffTypeList_.Add(other.formulaBuffTypeList_);
			if (other.FormulaId != 0U)
			{
				this.FormulaId = other.FormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x000B2661 File Offset: 0x000B0861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x000B266C File Offset: 0x000B086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsExpand = input.ReadBool();
						}
					}
					else
					{
						this.FormulaId = input.ReadUInt32();
					}
				}
				else
				{
					this.formulaBuffTypeList_.AddEntriesFrom(ref input, FormulaInfo._repeated_formulaBuffTypeList_codec);
				}
			}
		}

		// Token: 0x040019F7 RID: 6647
		private static readonly MessageParser<FormulaInfo> _parser = new MessageParser<FormulaInfo>(() => new FormulaInfo());

		// Token: 0x040019F8 RID: 6648
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019F9 RID: 6649
		public const int IsExpandFieldNumber = 11;

		// Token: 0x040019FA RID: 6650
		private bool isExpand_;

		// Token: 0x040019FB RID: 6651
		public const int FormulaBuffTypeListFieldNumber = 9;

		// Token: 0x040019FC RID: 6652
		private static readonly FieldCodec<FormulaBuffTypeInfo> _repeated_formulaBuffTypeList_codec = FieldCodec.ForMessage<FormulaBuffTypeInfo>(74U, FormulaBuffTypeInfo.Parser);

		// Token: 0x040019FD RID: 6653
		private readonly RepeatedField<FormulaBuffTypeInfo> formulaBuffTypeList_ = new RepeatedField<FormulaBuffTypeInfo>();

		// Token: 0x040019FE RID: 6654
		public const int FormulaIdFieldNumber = 10;

		// Token: 0x040019FF RID: 6655
		private uint formulaId_;
	}
}
