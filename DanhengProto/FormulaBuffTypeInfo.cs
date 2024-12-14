using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B5 RID: 1461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FormulaBuffTypeInfo : IMessage<FormulaBuffTypeInfo>, IMessage, IEquatable<FormulaBuffTypeInfo>, IDeepCloneable<FormulaBuffTypeInfo>, IBufferMessage
	{
		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x000B2034 File Offset: 0x000B0234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormulaBuffTypeInfo> Parser
		{
			get
			{
				return FormulaBuffTypeInfo._parser;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x000B203B File Offset: 0x000B023B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FormulaBuffTypeInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x000B204D File Offset: 0x000B024D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormulaBuffTypeInfo.Descriptor;
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000B2054 File Offset: 0x000B0254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaBuffTypeInfo()
		{
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000B205C File Offset: 0x000B025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaBuffTypeInfo(FormulaBuffTypeInfo other) : this()
		{
			this.key_ = other.key_;
			this.formulaBuffNum_ = other.formulaBuffNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x000B208D File Offset: 0x000B028D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaBuffTypeInfo Clone()
		{
			return new FormulaBuffTypeInfo(this);
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x000B2095 File Offset: 0x000B0295
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x000B209D File Offset: 0x000B029D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000B20A6 File Offset: 0x000B02A6
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x000B20AE File Offset: 0x000B02AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormulaBuffNum
		{
			get
			{
				return this.formulaBuffNum_;
			}
			set
			{
				this.formulaBuffNum_ = value;
			}
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000B20B7 File Offset: 0x000B02B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormulaBuffTypeInfo);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000B20C5 File Offset: 0x000B02C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormulaBuffTypeInfo other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.FormulaBuffNum == other.FormulaBuffNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x000B2104 File Offset: 0x000B0304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != 0U)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.FormulaBuffNum != 0)
			{
				num ^= this.FormulaBuffNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x000B215C File Offset: 0x000B035C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x000B2164 File Offset: 0x000B0364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000B2170 File Offset: 0x000B0370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormulaBuffNum != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FormulaBuffNum);
			}
			if (this.Key != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x000B21CC File Offset: 0x000B03CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Key);
			}
			if (this.FormulaBuffNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormulaBuffNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000B2224 File Offset: 0x000B0424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormulaBuffTypeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != 0U)
			{
				this.Key = other.Key;
			}
			if (other.FormulaBuffNum != 0)
			{
				this.FormulaBuffNum = other.FormulaBuffNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000B2274 File Offset: 0x000B0474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000B2280 File Offset: 0x000B0480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Key = input.ReadUInt32();
					}
				}
				else
				{
					this.FormulaBuffNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x040019F0 RID: 6640
		private static readonly MessageParser<FormulaBuffTypeInfo> _parser = new MessageParser<FormulaBuffTypeInfo>(() => new FormulaBuffTypeInfo());

		// Token: 0x040019F1 RID: 6641
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019F2 RID: 6642
		public const int KeyFieldNumber = 12;

		// Token: 0x040019F3 RID: 6643
		private uint key_;

		// Token: 0x040019F4 RID: 6644
		public const int FormulaBuffNumFieldNumber = 9;

		// Token: 0x040019F5 RID: 6645
		private int formulaBuffNum_;
	}
}
